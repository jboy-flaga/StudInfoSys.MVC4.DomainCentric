using System;


namespace StudInfoSys.Models
{
    public class Membership
    {
		public virtual int UserId { get; set; }
		public virtual DateTime? CreateDate { get; set; }
		public virtual string ConfirmationToken { get; set; }
		public virtual bool? IsConfirmed { get; set; }
        public virtual DateTime? LastPasswordFailureDate {get;set;}
        public virtual int PasswordFailuresSinceLastSuccess {get;set;}
        public virtual string Password {get;set;}
        public virtual DateTime? PasswordChangedDate {get;set;}
        public virtual string PasswordSalt {get;set;}
        public virtual string PasswordVerificationToken {get;set;}
        public virtual DateTime? PasswordVerificationTokenExpirationDate { get; set; }
    }
}
