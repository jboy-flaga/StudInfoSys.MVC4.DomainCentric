using StudInfoSys.DatabaseInitialization;
using StudInfoSys.DatabaseInitialization.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudInfoSys.DatabaseInitializationConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
            // JBOY: Setting the database initializer will be placed in global.asax in ASP.NET web apps
            // Set database initializer for migration (in code) (or use the <entityFramework><contexts><context> section in App.config
			// NOTE: The Seed method inside the Configuration class will always be called for each database initialization (just comment the Database.SetInitializer() method to prevent the Configuration.Seed() method from being executed the second time)
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<EFStudInfoSysContext, Configuration>());

            // JBOY: Use this code to turn off database initialization (impt in production code)
            // (or use the disableDatabaseInitialization="true" attribute in <entityFramework><contexts><context> section in App.config)
            // Database.SetInitializer<EFStudInfoSysContext>(null);

            CreateDatabase();
            Console.WriteLine("Database created.");

			Console.WriteLine("Press the Enter Key.");
			Console.ReadLine();
		}

		private static void CreateDatabase()
		{
			var context = new EFStudInfoSysContext();
			context.Database.Initialize(true);
		}
	}
}
