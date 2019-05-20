using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SampleDevops.Areas.Identity.Services
{
    public static class EmailInjection
    {
        public static void AddEmail(this IServiceCollection services, IConfiguration configuration, string sectionName = "SmtpSetting")
        {
            services.AddTransient<IEmailSender, EmailSender>();

            var section = configuration.GetSection(sectionName);
            services.Configure<SmtpSetting>(section);
        }
    }
}
