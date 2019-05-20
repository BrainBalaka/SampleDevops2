///OpenCatapultModelId:2
using System;
using System.Collections.Generic;

namespace SampleDevops.Models
{
    public class CategoryViewModel : BaseViewModel
    {
        public string Description { get; set; }
        public string Title { get; set; }
        public List<int> ProductsIds { get; set; }
    }
}
