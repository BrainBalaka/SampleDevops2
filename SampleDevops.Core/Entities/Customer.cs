///OpenCatapultModelId:3
using System;
using System.Collections.Generic;

namespace SampleDevops.Core.Entities
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
