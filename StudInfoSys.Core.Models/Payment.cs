using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudInfoSys.Core.Models
{
	public class Payment
	{
		public int Id { get; set; }
		public int RegistrationId { get; set; }
		public virtual Registration Registration { get; set; }

		public DateTime? DateAndTimeOfPayment { get; set; }
		public decimal? Amount { get; set; }
	}
}
