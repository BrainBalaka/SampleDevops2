///OpenCatapultModelId:4
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using SampleDevops.Core.Entities;
using SampleDevops.Core.Repositories;

namespace SampleDevops.Core.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<Order> GetOrderById(int id, CancellationToken cancellationToken = default(CancellationToken))
        {
            cancellationToken.ThrowIfCancellationRequested();

            return await _orderRepository.GetById(id, cancellationToken);
        }

        public async Task<List<Order>> GetOrders(CancellationToken cancellationToken = default(CancellationToken))
        {
            cancellationToken.ThrowIfCancellationRequested();

            return await _orderRepository.GetAll(cancellationToken);
        }

        public async Task<int> CreateOrder(Order entity, CancellationToken cancellationToken = default(CancellationToken))
        {
            cancellationToken.ThrowIfCancellationRequested();

            return await _orderRepository.Create(entity, cancellationToken);
        }

        public async Task UpdateOrder(Order updatedEntity, CancellationToken cancellationToken = default(CancellationToken))
        {
            cancellationToken.ThrowIfCancellationRequested();

            var entity = await _orderRepository.GetById(updatedEntity.Id, cancellationToken);
            entity.OrderDate = updatedEntity.OrderDate;
            entity.Customer = updatedEntity.Customer;
            entity.Products = updatedEntity.Products;
            await _orderRepository.Update(entity, cancellationToken);
        }

        public async Task DeleteOrder(int id, CancellationToken cancellationToken = default(CancellationToken))
        {
            cancellationToken.ThrowIfCancellationRequested();

            await _orderRepository.Delete(id, cancellationToken);
        }

    }
}

