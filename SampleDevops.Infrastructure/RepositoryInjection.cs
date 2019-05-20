using Microsoft.Extensions.DependencyInjection;
using SampleDevops.Core.Repositories;
using SampleDevops.Data;

namespace SampleDevops.Infrastructure
{
    public static class RepositoryInjection
    {
        public static void RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ISaleRepository, SaleRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
