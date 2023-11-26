using System;
using System.Collections.Generic;

namespace DBFirstDemo.Models
{
    public partial class Product
    {
        public Product()
        {
            BillDetails = new HashSet<BillDetail>();
            CartDetails = new HashSet<CartDetail>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public long Price { get; set; }
        public int AvailableQuantity { get; set; }
        public int Status { get; set; }
        public string Supplier { get; set; } = null!;
        public string Description { get; set; } = null!;
        // Cái bên dưới để thể hiện quan hệ 1-n giữa product và billDetails/CartDetails
        public virtual ICollection<BillDetail> BillDetails { get; set; }
        public virtual ICollection<CartDetail> CartDetails { get; set; }
    }
}
