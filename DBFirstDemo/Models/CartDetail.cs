using System;
using System.Collections.Generic;

namespace DBFirstDemo.Models
{
    public partial class CartDetail
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid IdSp { get; set; }
        public int Quantity { get; set; }

        public virtual Product IdSpNavigation { get; set; } = null!;
        public virtual Cart User { get; set; } = null!;
    }
}
