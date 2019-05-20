using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using SampleDevops.Data;
using SampleDevops.Data.Identity;

namespace SampleDevops.Infrastructure
{
    public static class IdentityInjection
    {
        public static void AddAppIdentity(this IServiceCollection services)
        {
            services.AddDefaultIdentity<ApplicationUser>()
                .AddRoles<ApplicationRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddScoped<IUserClaimsPrincipalFactory<ApplicationUser>, ApplicationUserClaimsPrincipalFactory>();
        }
    }
}
