///OpenCatapultModelId:5
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using SampleDevops.Core.Entities;

namespace SampleDevops.Core.Services
{
    public interface IProductService
    {
        Task<Product> GetProductById(int id, CancellationToken cancellationToken = default(CancellationToken));
        Task<List<Product>> GetProducts(CancellationToken cancellationToken = default(CancellationToken));
        Task<int> CreateProduct(Product entity, CancellationToken cancellationToken = default(CancellationToken));
        Task UpdateProduct(Product entity, CancellationToken cancellationToken = default(CancellationToken));
        Task DeleteProduct(int id, CancellationToken cancellationToken = default(CancellationToken));
    }
}

