///OpenCatapultModelId:5
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using SampleDevops.Core.Entities;
using SampleDevops.Core.Repositories;

namespace SampleDevops.Core.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Product> GetProductById(int id, CancellationToken cancellationToken = default(CancellationToken))
        {
            cancellationToken.ThrowIfCancellationRequested();

            return await _productRepository.GetById(id, cancellationToken);
        }

        public async Task<List<Product>> GetProducts(CancellationToken cancellationToken = default(CancellationToken))
        {
            cancellationToken.ThrowIfCancellationRequested();

            return await _productRepository.GetAll(cancellationToken);
        }

        public async Task<int> CreateProduct(Product entity, CancellationToken cancellationToken = default(CancellationToken))
        {
            cancellationToken.ThrowIfCancellationRequested();

            return await _productRepository.Create(entity, cancellationToken);
        }

        public async Task UpdateProduct(Product updatedEntity, CancellationToken cancellationToken = default(CancellationToken))
        {
            cancellationToken.ThrowIfCancellationRequested();

            var entity = await _productRepository.GetById(updatedEntity.Id, cancellationToken);
            entity.Title = updatedEntity.Title;
            entity.Description = updatedEntity.Description;
            entity.Price = updatedEntity.Price;
            await _productRepository.Update(entity, cancellationToken);
        }

        public async Task DeleteProduct(int id, CancellationToken cancellationToken = default(CancellationToken))
        {
            cancellationToken.ThrowIfCancellationRequested();

            await _productRepository.Delete(id, cancellationToken);
        }

    }
}

