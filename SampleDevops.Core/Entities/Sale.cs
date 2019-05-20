///OpenCatapultModelId:6
using System;
using System.Collections.Generic;

namespace SampleDevops.Core.Entities
{
    public class Sale : BaseEntity
    {
        public string Description { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
