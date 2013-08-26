using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudInfoSys.Core.Models
{
	public class AmountPerUnit
	{
		public int Id { get; set; }
		public int SchoolYearFrom { get; set; }
		public int SchoolYearTo { get; set; }
		public virtual Semester Semester { get; set; }
		public int DegreeId { get; set; }
		public virtual Degree Degree { get; set; }

		public decimal? Amount { get; set; }
	}
}
