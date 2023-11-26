using System;
using System.Collections.Generic;

namespace DBFirstDemo.Models
{
    public partial class BillDetail
    {
        public Guid Id { get; set; }
        public Guid BillId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        // Bên dưới cũng để thể hiện 1 BillDtails cần phụ thuộc (Chứa thông tin liên kết với) Bill và Product
        public virtual Bill Bill { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
    }
}
