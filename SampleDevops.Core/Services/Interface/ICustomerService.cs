///OpenCatapultModelId:3
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using SampleDevops.Core.Entities;

namespace SampleDevops.Core.Services
{
    public interface ICustomerService
    {
        Task<Customer> GetCustomerById(int id, CancellationToken cancellationToken = default(CancellationToken));
        Task<List<Customer>> GetCustomers(CancellationToken cancellationToken = default(CancellationToken));
        Task<int> CreateCustomer(Customer entity, CancellationToken cancellationToken = default(CancellationToken));
        Task UpdateCustomer(Customer entity, CancellationToken cancellationToken = default(CancellationToken));
        Task DeleteCustomer(int id, CancellationToken cancellationToken = default(CancellationToken));
    }
}

