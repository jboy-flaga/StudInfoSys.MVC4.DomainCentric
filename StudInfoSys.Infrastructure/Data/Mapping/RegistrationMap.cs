using StudInfoSys.Models;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace StudInfoSys.Infrastructure.Data.Mapping
{
    public class RegistrationMap : EntityTypeConfiguration<Registration>
    {
        public RegistrationMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Relationships
            this.HasRequired(t => t.Student)
                .WithMany(t => t.Registrations)
                .HasForeignKey(d => d.StudentId);
        }
    }
}
