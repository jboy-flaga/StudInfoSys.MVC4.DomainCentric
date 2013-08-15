using System.ComponentModel.DataAnnotations;

namespace StudInfoSys.Models
{
    public class Degree
    {
		public virtual int Id { get; set; }
        
        /// <summary>
        /// Gets or sets the title. 
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        /// <example>Kinder 1, Grade 4, First Year Hogh School, BSCS</example>
        [Required]
        [StringLength(100, MinimumLength=1)]
		public virtual string Title { get; set; }

        [Required]
        [StringLength(20)]
		public virtual string Acronym { get; set; }        
    }
}