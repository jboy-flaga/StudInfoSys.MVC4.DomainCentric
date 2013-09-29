using System.ComponentModel.DataAnnotations;

namespace StudInfoSys.Models
{
    public class Subject
    {
        //[HiddenInput]
        public virtual int Id { get; set; }

        [Display(Name="Subject Code")]
		public virtual string SubjectCode { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 1)]
        public virtual string Name { get; set; }

        [Range(0, 10)]
        [Display(Name = "Units")]
        public virtual int NumberOfUnits { get; set; }

        [DisplayFormat(DataFormatString = "{0:f}", NullDisplayText = "No Grade")]
        [Range(0, 100)]
        [Display(Name = "Grade")]
        public virtual decimal? GradeValue { get; set; }
    }
}