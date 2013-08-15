using System;
using System.Collections.Generic;

namespace StudInfoSys.Models
{
    public partial class GradeRecord
    {
        // public int Id { get; set; }
        public int SubjectId { get; set; }
        public decimal Grade { get; set; }
        public int? RegistrationId { get; set; }
        public virtual Registration Registration { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
