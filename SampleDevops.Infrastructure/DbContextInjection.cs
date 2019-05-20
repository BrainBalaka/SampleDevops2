using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SampleDevops.Data;

namespace SampleDevops.Infrastructure
{
    public static class DbContextInjection
    {
        public static void RegisterDbContext(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });
        }
    }
}
