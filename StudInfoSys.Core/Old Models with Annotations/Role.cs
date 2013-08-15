using System.Collections.Generic;
using System.Linq;

namespace StudInfoSys.Models
{
    public class Role
    {
		public virtual int RoleId { get; set; }
		public virtual string RoleName { get; set; }

		public virtual ICollection<User> Users { get; set; }

        public Role()
        {
            this.Users = new List<User>();
        }
    }
}
