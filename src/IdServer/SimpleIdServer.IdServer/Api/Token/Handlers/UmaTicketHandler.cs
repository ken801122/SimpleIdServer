﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Linq;
using SimpleIdServer.IdServer.Api.Token.Helpers;
using SimpleIdServer.IdServer.Api.Token.TokenBuilders;
using SimpleIdServer.IdServer.Api.Token.TokenProfiles;
using SimpleIdServer.IdServer.Api.Token.Validators;
using SimpleIdServer.IdServer.ClaimTokenFormats;
using SimpleIdServer.IdServer.Domains;
using SimpleIdServer.IdServer.Domains.DTOs;
using SimpleIdServer.IdServer.DTOs;
using SimpleIdServer.IdServer.Exceptions;
using SimpleIdServer.IdServer.Helpers;
using SimpleIdServer.IdServer.Options;
using SimpleIdServer.IdServer.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.Json.Nodes;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleIdServer.IdServer.Api.Token.Handlers
{
    public class UmaTicketHandler : BaseCredentialsHandler
    {
        private readonly IUmaTicketGrantTypeValidator _umaTicketGrantTypeValidator;
        private readonly IUmaPermissionTicketHelper _umaPermissionTicketHelper;
        private readonly IEnumerable<IClaimTokenFormat> _claimTokenFormats;
        private readonly IUmaResourceRepository _umaResourceRepository;
        private readonly IUmaPendingRequestRepository _umaPendingRequestRepository;
        private readonly IEnumerable<ITokenBuilder> _tokenBuilders;
        private readonly IEnumerable<ITokenProfile> _tokenProfiles;

        public UmaTicketHandler(IUmaTicketGrantTypeValidator umaTicketGrantTypeValidator, IUmaPermissionTicketHelper umaPermissionTicketHelper, 
            IEnumerable<IClaimTokenFormat> claimTokenFormats, IUmaResourceRepository umaResourceRepository,
            IUmaPendingRequestRepository umaPendingRequestRepository, IEnumerable<ITokenBuilder> tokenBuilders,
            IEnumerable<ITokenProfile> tokenProfiles, IClientAuthenticationHelper clientAuthenticationHelper, 
            IOptions<IdServerHostOptions> options) : base(clientAuthenticationHelper, options)
        {
            _umaTicketGrantTypeValidator = umaTicketGrantTypeValidator;
            _umaPermissionTicketHelper = umaPermissionTicketHelper;
            _claimTokenFormats = claimTokenFormats;
            _umaResourceRepository = umaResourceRepository;
            _umaPendingRequestRepository = umaPendingRequestRepository;
            _tokenBuilders = tokenBuilders;
            _tokenProfiles = tokenProfiles;
        }

        public const string GRANT_TYPE = "urn:ietf:params:oauth:grant-type:uma-ticket";
        public override string GrantType => GRANT_TYPE;

        public override async Task<IActionResult> Handle(HandlerContext context, CancellationToken cancellationToken)
        {
            try
            {
                _umaTicketGrantTypeValidator.Validate(context);
                var oauthClient = await AuthenticateClient(context, cancellationToken);
                context.SetClient(oauthClient);
                var ticket = context.Request.RequestData.GetTicket();
                var claimTokenFormat = context.Request.RequestData.GetClaimTokenFormat();
                if (string.IsNullOrWhiteSpace(claimTokenFormat))
                {
                    claimTokenFormat = Options.DefaultClaimTokenFormat;
                }

                var scopes = context.Request.RequestData.GetScopesFromAuthorizationRequest();
                var permissionTicket = await _umaPermissionTicketHelper.GetTicket(ticket);
                if (permissionTicket == null)
                    throw new OAuthException(ErrorCodes.INVALID_GRANT, ErrorMessages.INVALID_TICKET);

                ClaimTokenFormatFetcherResult claimTokenFormatFetcherResult = null;
                if (!string.IsNullOrWhiteSpace(claimTokenFormat))
                {
                    var claimTokenFormatFetcher = _claimTokenFormats.SingleOrDefault(c => c.Name == claimTokenFormat);
                    if (claimTokenFormatFetcher == null)
                    {
                        throw new OAuthException(ErrorCodes.INVALID_REQUEST, string.Format(ErrorMessages.BAD_TOKEN_FORMAT, claimTokenFormat));
                    }

                    claimTokenFormatFetcherResult = await claimTokenFormatFetcher.Fetch(context.Request.RequestData.GetClaimToken(), cancellationToken);
                }

                if (claimTokenFormatFetcherResult == null)
                    return BuildError(HttpStatusCode.Unauthorized, ErrorCodes.REQUEST_DENIED, ErrorMessages.REQUEST_DENIED);

                var invalidScopes = permissionTicket.Records.Any(rec => !scopes.All(sc => rec.Scopes.Contains(sc)));
                if (invalidScopes)
                    throw new OAuthException(ErrorCodes.INVALID_SCOPE, ErrorMessages.INVALID_SCOPE);

                var resourceIds = permissionTicket.Records.Select(r => r.ResourceId);
                var umaResources = await _umaResourceRepository.Query().Include(r => r.Permissions).ThenInclude(p => p.Claims).Where(r => resourceIds.Contains(r.Id)).ToListAsync(cancellationToken);
                var requiredClaims = new List<UMAResourcePermissionClaim>();
                foreach (var umaResource in umaResources)
                {
                    foreach (var permission in umaResource.Permissions)
                    {
                        if (permission.Scopes.Any(sc => scopes.Contains(sc)))
                        {
                            var unknownClaims = permission.Claims.Where(cl => !claimTokenFormatFetcherResult.Claims.Any(c => c.Type == cl.Name));
                            requiredClaims.AddRange(unknownClaims);
                        }
                    }
                }

                if (requiredClaims.Any())
                {
                    var rcs = new JsonArray();
                    foreach (var requiredClaim in requiredClaims)
                        rcs.Add(new JsonObject
                            {
                                { TokenRequestParameters.ClaimTokenFormat, Options.DefaultClaimTokenFormat },
                                { UMAResourcePermissionNames.ClaimType, requiredClaim.ClaimType },
                                { UMAResourcePermissionNames.ClaimFriendlyName, requiredClaim.FriendlyName },
                                { UMAResourcePermissionNames.ClaimName, requiredClaim.Name }
                            });
                    var needInfoResult = new JsonObject
                    {
                        { "need_info",  new JsonObject
                        {
                            { TokenRequestParameters.Ticket, permissionTicket.Id },
                            { "required_claims", rcs },
                            { "redirect_uri", context.Request.IssuerName }
                        }}
                    };
                    return new ContentResult
                    {
                        Content = needInfoResult.ToString(),
                        ContentType = "application/json",
                        StatusCode = (int)HttpStatusCode.Unauthorized
                    };
                }

                var isNotAuthorized = umaResources.Any(ua => ua.Permissions.Where(p => p.Scopes.Any(sc => scopes.Contains(sc)))
                    .All(pr => pr.Claims.All(cl => claimTokenFormatFetcherResult.Claims.Any(c => c.Type == cl.Name && !c.Value.ToString().Equals(cl.Value, StringComparison.InvariantCultureIgnoreCase)))));
                if (isNotAuthorized)
                {
                    var pendingRequests = await _umaPendingRequestRepository.Query().Where(r => r.TicketId == permissionTicket.Id).ToListAsync(cancellationToken);
                    if (pendingRequests.Any())
                        return BuildError(HttpStatusCode.Unauthorized, ErrorCodes.REQUEST_DENIED, ErrorMessages.REQUEST_DENIED);

                    foreach (var umaResource in umaResources)
                    {
                        var permissionTicketRecord = permissionTicket.Records.First(r => r.ResourceId == umaResource.Id);
                        var umaPendingRequest = new UMAPendingRequest(permissionTicket.Id, umaResource.Subject, DateTime.UtcNow)
                        {
                            Requester = claimTokenFormatFetcherResult.UserNameIdentifier,
                            Scopes = umaResource.Scopes,
                            Resource = umaResource
                        };
                        _umaPendingRequestRepository.Add(umaPendingRequest);
                    }

                    await _umaPendingRequestRepository.SaveChanges(cancellationToken);
                    return new ContentResult
                    {
                        ContentType = "application/json",
                        StatusCode = (int)HttpStatusCode.Unauthorized,
                        Content = new JObject
                        {
                            { "request_submitted", new JObject
                            {
                                { TokenRequestParameters.Ticket, permissionTicket.Id },
                                { "interval", Options.RequestSubmittedInterval }
                            } }
                        }.ToString()
                    };
                }

                var permissionClaims = new List<Dictionary<string, object>>();
                foreach (var permission in permissionTicket.Records)
                {
                    permissionClaims.Add(new Dictionary<string, object>
                    {
                        { UMAPermissionNames.ResourceId, permission.ResourceId },
                        { UMAPermissionNames.ResourceScopes, permission.Scopes }
                    });
                }

                var result = BuildResult(context, scopes);
                var parameter = new BuildTokenParameter
                {
                    Scopes = scopes,
                    AdditionalClaims = new Dictionary<string, object>
                    {
                        { "permissions", permissionClaims }
                    }
                };
                foreach (var tokenBuilder in _tokenBuilders)
                    await tokenBuilder.Build(parameter, context, cancellationToken);

                _tokenProfiles.First(t => t.Profile == (context.Client.PreferredTokenProfile ?? Options.DefaultTokenProfile)).Enrich(context);
                foreach (var kvp in context.Response.Parameters)
                {
                    result.Add(kvp.Key, kvp.Value);
                }

                return new OkObjectResult(result);
            }
            catch (OAuthException ex)
            {
                return BuildError(HttpStatusCode.BadRequest, ex.Code, ex.Message);
            }
        }
    }
}