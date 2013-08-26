using System;
using System.Collections.Generic;

namespace StudInfoSys.Core.Models
{
    public partial class Student
    {
        public Student()
        {
            this.Registrations = new List<Registration>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Photo { get; set; }
        public Gender Gender { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Registration> Registrations { get; set; }
    }
}
