///OpenCatapultModelId:2
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using SampleDevops.Core.Entities;
using SampleDevops.Core.Repositories;

namespace SampleDevops.Core.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<Category> GetCategoryById(int id, CancellationToken cancellationToken = default(CancellationToken))
        {
            cancellationToken.ThrowIfCancellationRequested();

            return await _categoryRepository.GetById(id, cancellationToken);
        }

        public async Task<List<Category>> GetCategories(CancellationToken cancellationToken = default(CancellationToken))
        {
            cancellationToken.ThrowIfCancellationRequested();

            return await _categoryRepository.GetAll(cancellationToken);
        }

        public async Task<int> CreateCategory(Category entity, CancellationToken cancellationToken = default(CancellationToken))
        {
            cancellationToken.ThrowIfCancellationRequested();

            return await _categoryRepository.Create(entity, cancellationToken);
        }

        public async Task UpdateCategory(Category updatedEntity, CancellationToken cancellationToken = default(CancellationToken))
        {
            cancellationToken.ThrowIfCancellationRequested();

            var entity = await _categoryRepository.GetById(updatedEntity.Id, cancellationToken);
            entity.Description = updatedEntity.Description;
            entity.Title = updatedEntity.Title;
            entity.Products = updatedEntity.Products;
            await _categoryRepository.Update(entity, cancellationToken);
        }

        public async Task DeleteCategory(int id, CancellationToken cancellationToken = default(CancellationToken))
        {
            cancellationToken.ThrowIfCancellationRequested();

            await _categoryRepository.Delete(id, cancellationToken);
        }

    }
}

