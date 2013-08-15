using StudInfoSys.Models;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace StudInfoSys.Infrastructure.Data.Mapping
{
    public class SubjectMap : EntityTypeConfiguration<Subject>
    {
        public SubjectMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
