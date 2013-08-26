using StudInfoSys.DatabaseInitialization.Migrations;
using System.Data.Entity.Migrations;
using System.Data.Entity.Migrations.Infrastructure;

namespace StudInfoSys.DatabaseInitialization
{
    // from Julie Lerman's course "Entity Framework Code First Migrations" module 2 section 11 - Code based Migrations
    public class MigrationConfigurationExecution
    {
        public static void RunMigration()
        {
            var migrationConfig = new Configuration();
            var migrator = new DbMigrator(migrationConfig);

            // JBOY: migrator.Update will look at the startup projects cofig file for the connection string
            // but you can provide a connection string to migrationConfig using "migrationConfig.TargetDatabase = connString"
            migrator.Update();
        }

        public static string CreateScriptFromMigration()
        {
            var migrationConfig = new Configuration();
            var migrator = new DbMigrator(migrationConfig);
            var scriptor = new MigratorScriptingDecorator(migrator);
            return scriptor.ScriptUpdate(sourceMigration: null, targetMigration: null);
        }
    }
}
