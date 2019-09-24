﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
using SimpleIdServer.Jwt.Jws;
using SimpleIdServer.OAuth.Domains.Clients;
using System.Threading.Tasks;

namespace SimpleIdServer.OpenID.ClaimsEnrichers
{
    public interface IClaimsSource
    {
        Task Enrich(JwsPayload jwsPayload, OAuthClient oauthClient);
    }
}