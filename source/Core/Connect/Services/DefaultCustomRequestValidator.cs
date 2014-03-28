﻿using System.Threading.Tasks;

namespace Thinktecture.IdentityServer.Core.Connect.Services
{
    public class DefaultCustomRequestValidator : ICustomRequestValidator
    {
        public Task<ValidationResult> ValidateAuthorizeRequestAsync(ValidatedAuthorizeRequest request, Core.Services.IUserService profile)
        {
            return Task.FromResult(new ValidationResult
            {
                IsError = false
            });
        }

        public Task<ValidationResult> ValidateTokenRequestAsync(ValidatedTokenRequest request, Core.Services.IUserService profile)
        {
            return Task.FromResult(new ValidationResult
            {
                IsError = false
            });
        }
    }
}