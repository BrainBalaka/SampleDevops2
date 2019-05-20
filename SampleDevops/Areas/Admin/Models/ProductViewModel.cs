///OpenCatapultModelId:5
using System;
using System.Collections.Generic;

namespace SampleDevops.Areas.Admin.Models
{
    public class ProductViewModel : BaseViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
