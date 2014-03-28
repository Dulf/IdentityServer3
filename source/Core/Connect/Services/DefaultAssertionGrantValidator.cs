﻿using System.Security.Claims;
using System.Threading.Tasks;

namespace Thinktecture.IdentityServer.Core.Connect.Services
{
    public class DefaultAssertionGrantValidator : IAssertionGrantValidator
    {
        public Task<ClaimsPrincipal> ValidateAsync(ValidatedTokenRequest request)
        {
            return Task.FromResult<ClaimsPrincipal>(null);
        }
    }
}