///OpenCatapultModelId:6
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using SampleDevops.Core.Entities;
using SampleDevops.Core.Repositories;

namespace SampleDevops.Core.Services
{
    public class SaleService : ISaleService
    {
        private readonly ISaleRepository _saleRepository;

        public SaleService(ISaleRepository saleRepository)
        {
            _saleRepository = saleRepository;
        }

        public async Task<Sale> GetSaleById(int id, CancellationToken cancellationToken = default(CancellationToken))
        {
            cancellationToken.ThrowIfCancellationRequested();

            return await _saleRepository.GetById(id, cancellationToken);
        }

        public async Task<List<Sale>> GetSales(CancellationToken cancellationToken = default(CancellationToken))
        {
            cancellationToken.ThrowIfCancellationRequested();

            return await _saleRepository.GetAll(cancellationToken);
        }

        public async Task<int> CreateSale(Sale entity, CancellationToken cancellationToken = default(CancellationToken))
        {
            cancellationToken.ThrowIfCancellationRequested();

            return await _saleRepository.Create(entity, cancellationToken);
        }

        public async Task UpdateSale(Sale updatedEntity, CancellationToken cancellationToken = default(CancellationToken))
        {
            cancellationToken.ThrowIfCancellationRequested();

            var entity = await _saleRepository.GetById(updatedEntity.Id, cancellationToken);
            entity.Description = updatedEntity.Description;
            entity.Title = updatedEntity.Title;
            entity.StartDate = updatedEntity.StartDate;
            entity.EndDate = updatedEntity.EndDate;
            entity.Products = updatedEntity.Products;
            await _saleRepository.Update(entity, cancellationToken);
        }

        public async Task DeleteSale(int id, CancellationToken cancellationToken = default(CancellationToken))
        {
            cancellationToken.ThrowIfCancellationRequested();

            await _saleRepository.Delete(id, cancellationToken);
        }

    }
}

