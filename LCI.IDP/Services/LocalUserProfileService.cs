﻿using IdentityServer4.Extensions;
using IdentityServer4.Models;
using IdentityServer4.Services;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace LCI.IDP.Services
{
    public class LocalUserProfileService : IProfileService
    {
        ILocalUserService _localUserService;

        public LocalUserProfileService(ILocalUserService localUserService)
        {
            _localUserService = localUserService ?? throw new System.ArgumentNullException(nameof(localUserService));
        }

        public async Task GetProfileDataAsync(ProfileDataRequestContext context)
        {
            var subjectId = context.Subject.GetSubjectId();
            var claimsForUser = (await _localUserService.GetUserClaimsBySubjectAsync(subjectId)).ToList();

            context.AddRequestedClaims(
                claimsForUser.Select(c => new Claim(c.Type, c.Value)).ToList());
        }

        public async Task IsActiveAsync(IsActiveContext context)
        {
            var subjectId = context.Subject.GetSubjectId();
            context.IsActive = await _localUserService.IsUserActive(subjectId);
        }
    }
}
