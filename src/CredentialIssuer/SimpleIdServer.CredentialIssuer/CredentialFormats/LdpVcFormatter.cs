﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
using SimpleIdServer.Did.Crypto;
using SimpleIdServer.Did.Models;
using SimpleIdServer.Vc;
using System;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace SimpleIdServer.CredentialIssuer.CredentialFormats
{
    public class LdpVcFormatter : BaseW3CVerifiableCredentialFormatter
    {
        public override string Format => FORMAT;

        public static string FORMAT = "ldp_vc";

        public override JsonNode Build(BuildCredentialRequest request, DidDocument didDocument, string verificationMethodId, IAsymmetricKey asymmetricKey)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));
            if (didDocument == null) throw new ArgumentNullException(nameof(didDocument));
            if (verificationMethodId == null) throw new ArgumentNullException(nameof(verificationMethodId));
            if (asymmetricKey == null) throw new ArgumentNullException(nameof(asymmetricKey));
            var credential = BuildCredential(request);
            SecuredDocument.New()
                .Secure(credential, didDocument, verificationMethodId, asymKey: asymmetricKey);
            return JsonObject.Parse(JsonSerializer.Serialize(credential));
        }
    }
}
