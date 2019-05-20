using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace SampleDevops.Data.Identity
{
    public class ApplicationRole : IdentityRole<int>
    {
        public ApplicationRole()
        {
        }

        public ApplicationRole(string roleName) : base(roleName)
        {
        }

        public ApplicationRole(int roleId, string roleName) : base(roleName)
        {
            Id = roleId;
            NormalizedName = roleName.ToUpper();
        }
    }
}

