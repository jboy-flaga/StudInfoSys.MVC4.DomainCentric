using StudInfoSys.Core.Models;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace StudInfoSys.Infratructure.Data.Mapping
{
    public class PaymentMap : EntityTypeConfiguration<Payment>
    {
		public PaymentMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

			// Relationships
			this.HasRequired(t => t.Registration)
				.WithMany(t => t.Payments)
				.HasForeignKey(t => t.RegistrationId);
        }
    }
}
