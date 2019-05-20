///OpenCatapultModelId:2
using SampleDevops.Core.Entities;
using SampleDevops.Core.Repositories;

namespace SampleDevops.Data
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}

