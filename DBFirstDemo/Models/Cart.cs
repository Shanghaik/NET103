using System;
using System.Collections.Generic;

namespace DBFirstDemo.Models
{
    public partial class Cart
    {
        public Cart()
        {
            CartDetails = new HashSet<CartDetail>();
        }

        public Guid UserId { get; set; }
        public string Description { get; set; } = null!;

        public virtual User User { get; set; } = null!;
        public virtual ICollection<CartDetail> CartDetails { get; set; }
    }
}
