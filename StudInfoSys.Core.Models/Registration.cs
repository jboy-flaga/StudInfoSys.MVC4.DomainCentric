using System;
using System.Collections.Generic;

namespace StudInfoSys.Core.Models
{
    public partial class Registration
    {
        public Registration()
        {
            this.GradeRecords = new List<GradeRecord>();
        }

        public int Id { get; set; }
        public int SchoolYearFrom { get; set; }
        public int SchoolYearTo { get; set; }
        public int DegreeId { get; set; }
        public System.DateTime DateOfRegistration { get; set; }

        public virtual Degree Degree { get; set; }
        public virtual Semester Semester { get; set; }
		public virtual Student Student { get; set; }
		public int? StudentId { get; set; }

        public virtual ICollection<GradeRecord> GradeRecords { get; set; }

		public virtual ICollection<Payment> Payments { get; set; }

    }
}
