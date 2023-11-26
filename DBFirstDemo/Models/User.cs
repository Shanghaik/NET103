using System;
using System.Collections.Generic;

namespace DBFirstDemo.Models
{
    public partial class User
    {
        public User()
        {
            Bills = new HashSet<Bill>();
            Roles = new HashSet<Role>();
        }

        public Guid Id { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string RoleId { get; set; } = null!;
        public string Status { get; set; } = null!;

        public virtual Cart? Cart { get; set; }
        public virtual ICollection<Bill> Bills { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
    }
}
