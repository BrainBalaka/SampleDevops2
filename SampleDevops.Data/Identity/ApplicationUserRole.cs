using Microsoft.AspNetCore.Identity;

namespace SampleDevops.Data.Identity
{
    public class ApplicationUserRole : IdentityUserRole<int>
    {

        public ApplicationUserRole()
        {
        }

        public ApplicationUserRole(int userId, int roleId)
        {
            UserId = userId;
            RoleId = roleId;
        }
    }
}

