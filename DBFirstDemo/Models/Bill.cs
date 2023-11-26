using System;
using System.Collections.Generic;

namespace DBFirstDemo.Models
{
    public partial class Bill
    {
        public Bill()
        {
            BillDetails = new HashSet<BillDetail>();
        }

        public Guid Id { get; set; }
        public DateTime CreateDate { get; set; }
        public Guid UserId { get; set; }
        public int Status { get; set; }

        public virtual User User { get; set; } = null!;
        public virtual ICollection<BillDetail> BillDetails { get; set; }
    }
}
