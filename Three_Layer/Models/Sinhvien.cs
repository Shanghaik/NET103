using System;
using System.Collections.Generic;

namespace Three_Layer.Models
{
    public partial class Sinhvien
    {
        public int Id { get; set; }
        public string Ten { get; set; } = null!;
        public string? Email { get; set; }
        public string? Sdt { get; set; }
        public int? Idtruong { get; set; }

        public virtual TruongHoc? IdtruongNavigation { get; set; }
    }
}
