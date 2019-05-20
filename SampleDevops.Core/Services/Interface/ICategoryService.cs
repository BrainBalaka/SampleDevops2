///OpenCatapultModelId:2
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using SampleDevops.Core.Entities;

namespace SampleDevops.Core.Services
{
    public interface ICategoryService
    {
        Task<Category> GetCategoryById(int id, CancellationToken cancellationToken = default(CancellationToken));
        Task<List<Category>> GetCategories(CancellationToken cancellationToken = default(CancellationToken));
        Task<int> CreateCategory(Category entity, CancellationToken cancellationToken = default(CancellationToken));
        Task UpdateCategory(Category entity, CancellationToken cancellationToken = default(CancellationToken));
        Task DeleteCategory(int id, CancellationToken cancellationToken = default(CancellationToken));
    }
}

