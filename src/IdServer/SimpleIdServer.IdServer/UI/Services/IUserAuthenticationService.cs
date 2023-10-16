﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
using SimpleIdServer.IdServer.Domains;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleIdServer.IdServer.UI.Services;

public interface IUserAuthenticationService
{
    Task<User> GetUser(string authenticatedUserId, object viewModel, string realm, CancellationToken cancellationToken);
    Task<CredentialsValidationResult> Validate(string realm, string authenticatedUserId, object viewModel, CancellationToken cancellationToken);
    Task<CredentialsValidationResult> Validate(string realm, User authenticatedUser, object viewModel, CancellationToken cancellationToken);
}

public enum ValidationStatus
{
    AUTHENTICATE = 0,
    INVALIDCREDENTIALS = 1,
    NOCONTENT = 2,
    UNKNOWN_USER = 3
}

public record CredentialsValidationResult
{
    private CredentialsValidationResult(User authenticatedUser)
    {
        AuthenticatedUser = authenticatedUser;
        Status = ValidationStatus.AUTHENTICATE;
    }

    private CredentialsValidationResult(ValidationStatus status)
    {
        Status = status;
    }

    public User AuthenticatedUser { get; private set; }
    public ValidationStatus Status { get; private set; }

    public static CredentialsValidationResult Ok(User user) => new CredentialsValidationResult(user);

    public static CredentialsValidationResult Error(ValidationStatus status) => new CredentialsValidationResult(status);
}