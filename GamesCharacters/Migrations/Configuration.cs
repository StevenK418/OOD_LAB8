namespace GamesCharacters.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GamesCharacters.ComputerGameData>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "GamesCharacters.ComputerGameData";
        }

        protected override void Seed(GamesCharacters.ComputerGameData context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
