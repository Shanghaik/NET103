using System;
using System.Collections.Generic;

namespace Three_Layer.Models
{
    public partial class TruongHoc
    {
        public TruongHoc()
        {
            Sinhviens = new HashSet<Sinhvien>();
        }

        public int Id { get; set; }
        public string Ten { get; set; } = null!;
        public string Diachi { get; set; } = null!;
        public DateTime? Ngaythanhlap { get; set; }

        public virtual ICollection<Sinhvien> Sinhviens { get; set; }
    }
}
