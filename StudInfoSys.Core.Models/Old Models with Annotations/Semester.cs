using System.ComponentModel.DataAnnotations;

namespace StudInfoSys.Models
{
    public class Semester
    {
        //[HiddenInput]
        public virtual int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 1)]
        [Display(Name = "Semester")]
        public virtual string Name { get; set; }
    }
}