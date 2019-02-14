namespace BooksLibrary.DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BooksLibrary.DAL.Context.BooksLibraryContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "BooksLibrary.DAL.Context.BooksLibraryContext";
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(BooksLibrary.DAL.Context.BooksLibraryContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
