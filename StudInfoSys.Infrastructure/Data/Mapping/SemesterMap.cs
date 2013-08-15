using StudInfoSys.Models;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace StudInfoSys.Infrastructure.Data.Mapping
{
    public class SemesterMap : EntityTypeConfiguration<Semester>
    {
        public SemesterMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
