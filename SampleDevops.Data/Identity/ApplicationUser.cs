using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace SampleDevops.Data.Identity
{
    public class ApplicationUser : IdentityUser<int>
    {
        public ApplicationUser()
        {
        }

        public ApplicationUser(string userName) : base(userName)
        {
        }

        public ApplicationUser(int userId, string userEmail) : base(userEmail)
        {
            Id = userId;
            NormalizedUserName = userEmail.ToUpper();
            Email = userEmail;
            NormalizedEmail = userEmail.ToUpper();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }
    }
}

