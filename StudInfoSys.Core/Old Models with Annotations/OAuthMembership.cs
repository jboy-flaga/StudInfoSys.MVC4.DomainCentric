using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudInfoSys.Models
{
	public class OAuthMembership
	{
		public virtual string Provider { get; set; }
		public virtual string ProviderUserId { get; set; }
		public virtual int UserId { get; set; }
	}
}
