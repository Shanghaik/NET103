using System;
using System.Collections.Generic;

namespace DBFirstDemo.Models
{
    public partial class Role
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int Status { get; set; }
        public Guid? UserId { get; set; }

        public virtual User? User { get; set; }
    }
}
