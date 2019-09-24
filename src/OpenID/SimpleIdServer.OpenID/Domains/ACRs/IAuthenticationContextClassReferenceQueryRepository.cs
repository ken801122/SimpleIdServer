﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
using SimpleIdServer.OpenID.Domains;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleIdServer.OpenID.Domains.ACRs
{
    public interface IAuthenticationContextClassReferenceQueryRepository
    {
        Task<AuthenticationContextClassReference> FindACRByName(string name);
    }
}
