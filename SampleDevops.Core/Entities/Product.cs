///OpenCatapultModelId:5
using System;
using System.Collections.Generic;

namespace SampleDevops.Core.Entities
{
    public class Product : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
