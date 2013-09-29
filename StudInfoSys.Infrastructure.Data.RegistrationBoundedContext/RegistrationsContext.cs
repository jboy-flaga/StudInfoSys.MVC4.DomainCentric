using StudInfoSys.Core.Models;
using StudInfoSys.Infratructure.Data.Mapping;
using System.Data.Entity;

namespace StudInfoSys.Infrastructure.Data.RegistrationBoundedContext
{
    public class RegistrationsContext : DbContext, IRegistrationsContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Registration> Registrations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new StudentMap());
            modelBuilder.Configurations.Add(new RegistrationMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
