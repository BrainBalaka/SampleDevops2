///OpenCatapultModelId:6
using System;
using System.Collections.Generic;

namespace SampleDevops.Areas.Admin.Models
{
    public class SaleViewModel : BaseViewModel
    {
        public string Description { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<int> ProductsIds { get; set; }
    }
}
