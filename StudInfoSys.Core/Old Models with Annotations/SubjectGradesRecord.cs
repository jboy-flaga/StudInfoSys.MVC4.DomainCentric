using System.ComponentModel.DataAnnotations;

namespace StudInfoSys.Models
{
	public class SubjectGradeRecord
	{
		public virtual int Id { get; set; }

		public virtual Subject Subject { get; set; }
		[Required]
		public virtual int SubjectId { get; set; }

		public virtual decimal Grade { get; set; }

		//for navigation only
		public virtual Registration Registration { get; set; }
		public virtual int RegistrationId { get; set; } //for easy access to Registration's Id
	}
}