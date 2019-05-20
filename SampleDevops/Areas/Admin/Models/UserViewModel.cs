///OpenCatapultModelId:1
using System;
using System.Collections.Generic;

namespace SampleDevops.Areas.Admin.Models
{
    public class UserViewModel : BaseViewModel
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }
    }
}
