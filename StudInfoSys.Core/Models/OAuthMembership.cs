using System;
using System.Collections.Generic;

namespace StudInfoSys.Models
{
    public partial class OAuthMembership
    {
        public string Provider { get; set; }
        public string ProviderUserId { get; set; }
        public int UserId { get; set; }
    }
}
