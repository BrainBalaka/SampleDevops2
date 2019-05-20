///OpenCatapultModelId:2
using System;
using System.Collections.Generic;

namespace SampleDevops.Core.Entities
{
    public class Category : BaseEntity
    {
        public string Description { get; set; }
        public string Title { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
