///OpenCatapultModelId:6
using SampleDevops.Core.Entities;
using SampleDevops.Core.Repositories;

namespace SampleDevops.Data
{
    public class SaleRepository : BaseRepository<Sale>, ISaleRepository
    {
        public SaleRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}

