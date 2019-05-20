using Microsoft.Extensions.DependencyInjection;
using SampleDevops.Core.Services;

namespace SampleDevops
{
    public static class ServiceInjection
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<ISaleService, SaleService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IUserService, UserService>();
        }
    }
}
