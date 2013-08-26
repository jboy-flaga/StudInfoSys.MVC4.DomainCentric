namespace StudInfoSys.DatabaseInitialization.Migrations
{
	using System;
	using System.Data.Entity;
	using System.Data.Entity.Migrations;
	using System.Linq;

	// JBOY: DELETED "internal sealed" and changed to "public" because this class is used in the DatabaseInitializationConsoleApp: 
	// internal sealed class Configuration : DbMigrationsConfiguration<StudInfoSys.Infrastructure.Data.EFStudInfoSysContext>
	public class Configuration : DbMigrationsConfiguration<StudInfoSys.DatabaseInitialization.EFStudInfoSysContext>
	{
		public Configuration()
		{
			AutomaticMigrationsEnabled = true;
			AutomaticMigrationDataLossAllowed = true;
		}

		protected override void Seed(StudInfoSys.DatabaseInitialization.EFStudInfoSysContext context)
		{
			//  This method will be called after migrating to the latest version.

			//  You can use the DbSet<T>.AddOrUpdate() helper extension method 
			//  to avoid creating duplicate seed data. E.g.
			//
			//    context.People.AddOrUpdate(
			//      p => p.FullName,
			//      new Person { FullName = "Andrew Peters" },
			//      new Person { FullName = "Brice Lambson" },
			//      new Person { FullName = "Rowan Miller" }
			//    );
			//
		}
	}
}
