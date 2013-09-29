using System;
using System.Collections.Generic;

namespace StudInfoSys.Core.Models
{
    public partial class Subject
    {
        public int Id { get; set; }
        public string SubjectCode { get; set; }
        public string Name { get; set; }
        public int NumberOfUnits { get; set; }
        public decimal? Grade { get; set; }
    }
}
