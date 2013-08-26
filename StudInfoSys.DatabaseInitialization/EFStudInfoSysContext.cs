using StudInfoSys.Infratructure.Data.Mapping;
using StudInfoSys.DatabaseInitialization.Migrations;
using StudInfoSys.Core.Models;
using System.Data.Entity;

namespace StudInfoSys.DatabaseInitialization
{
    public class EFStudInfoSysContext : DbContext
	{
		public DbSet<Degree> Degrees { get; set; }
        public DbSet<GradeRecord> GradeRecords { get; set; }
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
		public DbSet<AmountPerUnit> AmountPerUnit { get; set; }
		public DbSet<Payment> Payments { get; set; }
		// public DbSet<Semester> Semesters { get; set; }
		public DbSet<User> Users { get; set; }


        public EFStudInfoSysContext()
            : this("StudInfoSysDbConnection")
        { }

        public EFStudInfoSysContext(string nameOrConnectionString="")
            : base(nameOrConnectionString)
        {
			Configuration.LazyLoadingEnabled = true;
		}

        //static EFStudInfoSysContext()
        //{
        //    // Database.SetInitializer(new DropCreateDatabaseIfModelChanges<EFStudInfoSysContext>());
        //    // Database.SetInitializer(new MigrateDatabaseToLatestVersion<EFStudInfoSysContext, Configuration>());
        //    // Or use/uncomment <entityFramework> section in App.config of the StudInfoSys.DatabaseInitializationConsoleApp project to automate migration
        //}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Configurations.Add(new AmountPerUnitMap());
			modelBuilder.Configurations.Add(new DegreeMap());
			modelBuilder.Configurations.Add(new GradeRecordMap());
			modelBuilder.Configurations.Add(new PaymentMap());
			modelBuilder.Configurations.Add(new RegistrationMap());
			modelBuilder.Configurations.Add(new StudentMap());
			modelBuilder.Configurations.Add(new SubjectMap());
			modelBuilder.Configurations.Add(new UserMap());

			// Add ASP.NET WebPages SimpleSecurity tables
			modelBuilder.Configurations.Add(new MembershipMap());
			modelBuilder.Configurations.Add(new OAuthMembershipMap());
			modelBuilder.Configurations.Add(new RolesMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}