﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.JsonWebTokens;
using SimpleIdServer.IdServer.Domains;
using SimpleIdServer.IdServer.Exceptions;
using SimpleIdServer.IdServer.Helpers;
using SimpleIdServer.IdServer.Options;
using SimpleIdServer.IdServer.Store;
using SimpleIdServer.IdServer.UI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleIdServer.IdServer.UI
{
    public class ExternalAuthenticateController : BaseAuthenticateController
    {
        private const string SCHEME_NAME = "scheme";
        private const string RETURN_URL_NAME = "returnUrl";
        private readonly ILogger<ExternalAuthenticateController> _logger;
        private readonly IAuthenticationSchemeProvider _authenticationSchemeProvider;
        private readonly IServiceProvider _serviceProvider;
        private readonly IUserTransformer _userTransformer;

        public ExternalAuthenticateController(
            IOptions<IdServerHostOptions> options,
            IDataProtectionProvider dataProtectionProvider,
            IClientRepository clientRepository,
            IAmrHelper amrHelper,
            IUserRepository userRepository,
            ILogger<ExternalAuthenticateController> logger,
            IAuthenticationSchemeProvider authenticationSchemeProvider,
            IServiceProvider serviceProvider,
            IUserTransformer userTransformer) : base(options, dataProtectionProvider, clientRepository, amrHelper, userRepository, userTransformer)
        {
            _logger = logger;
            _authenticationSchemeProvider = authenticationSchemeProvider;
            _serviceProvider = serviceProvider;
            _userTransformer = userTransformer;
        }

        [HttpGet]
        public IActionResult Login(string scheme, string returnUrl)
        {
            if (string.IsNullOrWhiteSpace(scheme))
                throw new OAuthException(ErrorCodes.INVALID_REQUEST, string.Format(ErrorMessages.MISSING_PARAMETER, nameof(scheme)));

            var items = new Dictionary<string, string>
            {
                { SCHEME_NAME, scheme }
            };
            if (!string.IsNullOrWhiteSpace(returnUrl))
            {
                items.Add(RETURN_URL_NAME, returnUrl);
            }
            var props = new AuthenticationProperties(items)
            {
                RedirectUri = Url.Action(nameof(Callback), new { scheme = scheme }),
            };
            return Challenge(props, scheme);
        }

        [HttpGet]
        public async Task<IActionResult> Callback(string scheme, CancellationToken cancellationToken)
        {
            var result = await HttpContext.AuthenticateAsync(scheme);
            if (result == null || !result.Succeeded)
            {
                if (result.Failure != null)
                {
                    _logger.LogError(result.Failure.ToString());
                }

                throw new OAuthException(ErrorCodes.INVALID_REQUEST, ErrorMessages.BAD_EXTERNAL_AUTHENTICATION);
            }

            var user = await JustInTimeProvision(result, cancellationToken);
            var returnUrl = "~/";
            if (result.Properties.Items.ContainsKey(RETURN_URL_NAME))
            {
                returnUrl = result.Properties.Items[RETURN_URL_NAME];
                returnUrl = Unprotect(returnUrl);
            }

            return await Sign(returnUrl, "externalAuth", user, cancellationToken, true);
        }

        private async Task<User> JustInTimeProvision(AuthenticateResult authResult, CancellationToken cancellationToken)
        {
            var scheme = authResult.Properties.Items[SCHEME_NAME];
            var principal = authResult.Principal;
            var sub = GetClaim(principal, JwtRegisteredClaimNames.Sub) ?? GetClaim(principal, ClaimTypes.NameIdentifier);
            if (string.IsNullOrWhiteSpace(sub))
            {
                _logger.LogError("There is not valid subject");
                throw new OAuthException(ErrorCodes.INVALID_REQUEST, ErrorMessages.BAD_EXTERNAL_AUTHENTICATION_USER);
            }

            var user = await UserRepository.Query()
                .Include(u => u.ExternalAuthProviders)
                .Include(u => u.Sessions)
                .Include(u => u.OAuthUserClaims)
                .FirstOrDefaultAsync(u => u.ExternalAuthProviders.Any(e => e.Scheme == scheme && e.Subject == sub), cancellationToken);
            if (user == null)
            {
                _logger.LogInformation($"Start to provision the user '{sub}'");
                user = _userTransformer.Transform(principal);
                user.AddExternalAuthProvider(scheme, sub);
                UserRepository.Add(user);
                await UserRepository.SaveChanges(cancellationToken);
                _logger.LogInformation($"Finish to provision the user '{sub}'");
            }

            return user;
        }

        private static string GetClaim(ClaimsPrincipal principal, string claimType)
        {
            var claim = principal.Claims.FirstOrDefault(c => c.Type == claimType);
            if (claim == null || string.IsNullOrWhiteSpace(claim.Value))
                return null;
            return claim.Value;
        }
    }
}