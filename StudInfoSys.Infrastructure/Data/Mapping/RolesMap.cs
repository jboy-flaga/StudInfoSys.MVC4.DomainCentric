using StudInfoSys.Models;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace StudInfoSys.Infrastructure.Data.Mapping
{
    public class RolesMap : EntityTypeConfiguration<Role>
    {
        public RolesMap()
        {
            // Primary Key
            this.HasKey(t => t.RoleId);

            // Properties
            this.Property(t => t.RoleName)
                .IsRequired()
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("webpages_Roles");
        }
    }
}
