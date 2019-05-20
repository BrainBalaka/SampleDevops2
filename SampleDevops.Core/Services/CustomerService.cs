///OpenCatapultModelId:3
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using SampleDevops.Core.Entities;
using SampleDevops.Core.Repositories;

namespace SampleDevops.Core.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<Customer> GetCustomerById(int id, CancellationToken cancellationToken = default(CancellationToken))
        {
            cancellationToken.ThrowIfCancellationRequested();

            return await _customerRepository.GetById(id, cancellationToken);
        }

        public async Task<List<Customer>> GetCustomers(CancellationToken cancellationToken = default(CancellationToken))
        {
            cancellationToken.ThrowIfCancellationRequested();

            return await _customerRepository.GetAll(cancellationToken);
        }

        public async Task<int> CreateCustomer(Customer entity, CancellationToken cancellationToken = default(CancellationToken))
        {
            cancellationToken.ThrowIfCancellationRequested();

            return await _customerRepository.Create(entity, cancellationToken);
        }

        public async Task UpdateCustomer(Customer updatedEntity, CancellationToken cancellationToken = default(CancellationToken))
        {
            cancellationToken.ThrowIfCancellationRequested();

            var entity = await _customerRepository.GetById(updatedEntity.Id, cancellationToken);
            entity.Name = updatedEntity.Name;
            entity.User = updatedEntity.User;
            await _customerRepository.Update(entity, cancellationToken);
        }

        public async Task DeleteCustomer(int id, CancellationToken cancellationToken = default(CancellationToken))
        {
            cancellationToken.ThrowIfCancellationRequested();

            await _customerRepository.Delete(id, cancellationToken);
        }

    }
}

