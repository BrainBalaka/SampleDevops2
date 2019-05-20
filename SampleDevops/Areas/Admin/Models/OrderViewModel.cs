///OpenCatapultModelId:4
using System;
using System.Collections.Generic;

namespace SampleDevops.Areas.Admin.Models
{
    public class OrderViewModel : BaseViewModel
    {
        public DateTime OrderDate { get; set; }
        public int CustomerId { get; set; }
        public List<int> ProductsIds { get; set; }
    }
}
