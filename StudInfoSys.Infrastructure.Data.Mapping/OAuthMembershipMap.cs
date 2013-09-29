using StudInfoSys.Core.Models;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace StudInfoSys.Infratructure.Data.Mapping
{
    public class OAuthMembershipMap : EntityTypeConfiguration<OAuthMembership>
    {
        public OAuthMembershipMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Provider, t.ProviderUserId });

            // Properties
            this.Property(t => t.Provider)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.ProviderUserId)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("webpages_OAuthMembership");
        }
    }
}
