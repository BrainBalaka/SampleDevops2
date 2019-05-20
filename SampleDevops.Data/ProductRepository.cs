///OpenCatapultModelId:5
using SampleDevops.Core.Entities;
using SampleDevops.Core.Repositories;

namespace SampleDevops.Data
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}

