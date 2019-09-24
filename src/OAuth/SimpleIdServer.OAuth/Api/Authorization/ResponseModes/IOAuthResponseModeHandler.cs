﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
using Microsoft.AspNetCore.Http;

namespace SimpleIdServer.OAuth.Api.Authorization.ResponseModes
{
    public interface IOAuthResponseModeHandler : IOAuthResponseMode
    {
        void Handle(RedirectURLAuthorizationResponse authorizationResponse, HttpContext httpContext);
    }
}