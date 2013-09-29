using StudInfoSys.Core.Models;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace StudInfoSys.Infratructure.Data.Mapping
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.FirstName)
                .HasMaxLength(100);

            this.Property(t => t.LastName)
                .HasMaxLength(100);

            this.Property(t => t.Username)
                .IsRequired()
                .HasMaxLength(200);

            // Relationships
            this.HasMany(t => t.Role)
                .WithMany(t => t.Users)
                .Map(m =>
                    {
                        m.ToTable("webpages_UsersInRoles");
                        m.MapLeftKey("UserId");
                        m.MapRightKey("RoleId");
                    });
        }
    }
}
