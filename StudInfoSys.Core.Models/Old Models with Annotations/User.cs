using System.Collections.Generic;

namespace StudInfoSys.Models
{
    public class User
    {
		public virtual int Id { get; set; }
		public virtual string FirstName { get; set; }
		public virtual string LastName { get; set; }
		public virtual string Username { get; set; }

        public virtual ICollection<Role> Roles { get; set; }

        public User() 
        {
            this.Roles = new List<Role>();
        }
    }
}
