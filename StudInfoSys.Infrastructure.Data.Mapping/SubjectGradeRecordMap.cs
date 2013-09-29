using StudInfoSys.Core.Models;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace StudInfoSys.Infratructure.Data.Mapping
{
    public class GradeRecordMap : EntityTypeConfiguration<GradeRecord>
    {
        public GradeRecordMap()
        {
            // Primary Key
			this.HasKey(t => new { t.RegistrationId, t.SubjectId });
        }
    }
}
