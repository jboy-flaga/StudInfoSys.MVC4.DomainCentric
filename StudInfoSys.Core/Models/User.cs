using System;
using System.Collections.Generic;

namespace StudInfoSys.Models
{
    public partial class User
    {
        public User()
        {
            this.Role = new List<Role>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public virtual ICollection<Role> Role { get; set; }
    }
}
