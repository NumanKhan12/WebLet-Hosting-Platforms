using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace WEBLET.Data
{
    public class ClaimStore
         : UserClaimsPrincipalFactory<IdentityUser>
    {
        public ClaimStore(
        UserManager<IdentityUser> userManager,
        IOptions<IdentityOptions> optionsAccessor)
            : base(userManager, optionsAccessor)
        {
        }

        protected override async Task<ClaimsIdentity> GenerateClaimsAsync(IdentityUser user)
        {
            return new ClaimsIdentity();
        }
}
}
