using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using SampleDevops.Core.Entities;

namespace SampleDevops.Core.Repositories
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        Task<TEntity> GetById(int id, CancellationToken cancellationToken = default(CancellationToken));
        Task<List<TEntity>> GetAll(CancellationToken cancellationToken = default(CancellationToken));
        Task<IEnumerable<TEntity>> GetBySpec(ISpecification<TEntity> spec, CancellationToken cancellationToken = default(CancellationToken));
        Task<TEntity> GetSingleBySpec(ISpecification<TEntity> spec, CancellationToken cancellationToken = default(CancellationToken));
        Task<int> CountBySpec(ISpecification<TEntity> spec, CancellationToken cancellationToken = default(CancellationToken));
        Task<int> Create(TEntity entity, CancellationToken cancellationToken = default(CancellationToken));
        Task Update(TEntity entity, CancellationToken cancellationToken = default(CancellationToken));
        Task Delete(int id, CancellationToken cancellationToken = default(CancellationToken));
    }
}

