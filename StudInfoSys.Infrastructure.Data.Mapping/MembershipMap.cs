using StudInfoSys.Core.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace StudInfoSys.Infratructure.Data.Mapping
{
    public class MembershipMap : EntityTypeConfiguration<Membership>
    {
        public MembershipMap()
        {
            // Primary Key
            this.HasKey(t => t.UserId);

            // Properties
            this.Property(t => t.UserId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ConfirmationToken)
                .HasMaxLength(128);

            this.Property(t => t.Password)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.PasswordSalt)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.PasswordVerificationToken)
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("webpages_Membership");
        }
    }
}
