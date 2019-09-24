﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
using SimpleIdServer.OAuth.Domains;
using System.Collections.Generic;
using System.Linq;

namespace SimpleIdServer.OAuth.Extensions
{
    public static class TranslationExtensions
    {
        public static string GetTranslation(this ICollection<OAuthTranslation> translations, string defaultLanguage, string defaultValue)
        {
            var translation = translations.FirstOrDefault(t => t.Language == defaultLanguage);
            return translation == null ? defaultValue : translation.Value;
        }
    }
}