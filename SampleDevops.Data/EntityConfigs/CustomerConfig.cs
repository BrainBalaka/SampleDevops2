///OpenCatapultModelId:3
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SampleDevops.Core.Entities;
using SampleDevops.Data.Identity;

namespace SampleDevops.Data.EntityConfigs
{
    public class CustomerConfig : BaseEntityConfig<Customer>
    {
        public override void Configure(EntityTypeBuilder<Customer> builder)
        {
            base.Configure(builder);
            builder.Ignore(m => m.User);
            builder.HasOne(typeof(ApplicationUser)).WithOne().HasForeignKey(typeof(Customer), "UserId");
        }
    }
}
