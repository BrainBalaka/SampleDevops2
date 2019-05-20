using System;

namespace SampleDevops.Core.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public string ConcurrencyStamp { get; set; } = Guid.NewGuid().ToString();
    }
}

