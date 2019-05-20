///OpenCatapultModelId:6
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using SampleDevops.Core.Entities;

namespace SampleDevops.Core.Services
{
    public interface ISaleService
    {
        Task<Sale> GetSaleById(int id, CancellationToken cancellationToken = default(CancellationToken));
        Task<List<Sale>> GetSales(CancellationToken cancellationToken = default(CancellationToken));
        Task<int> CreateSale(Sale entity, CancellationToken cancellationToken = default(CancellationToken));
        Task UpdateSale(Sale entity, CancellationToken cancellationToken = default(CancellationToken));
        Task DeleteSale(int id, CancellationToken cancellationToken = default(CancellationToken));
    }
}

