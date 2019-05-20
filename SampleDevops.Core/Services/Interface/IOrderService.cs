///OpenCatapultModelId:4
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using SampleDevops.Core.Entities;

namespace SampleDevops.Core.Services
{
    public interface IOrderService
    {
        Task<Order> GetOrderById(int id, CancellationToken cancellationToken = default(CancellationToken));
        Task<List<Order>> GetOrders(CancellationToken cancellationToken = default(CancellationToken));
        Task<int> CreateOrder(Order entity, CancellationToken cancellationToken = default(CancellationToken));
        Task UpdateOrder(Order entity, CancellationToken cancellationToken = default(CancellationToken));
        Task DeleteOrder(int id, CancellationToken cancellationToken = default(CancellationToken));
    }
}

