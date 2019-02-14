using BooksLibrary.DAL.Entities;
using BooksLibrary.DAL.Initializators;
using System.Data.Entity;

namespace BooksLibrary.DAL.Context
{
  public class BooksLibraryContext : DbContext
  {
    public BooksLibraryContext()
      :base("BooksLibraryConnectionString")
    {

    }

    public BooksLibraryContext(string connectionString)
      :base(connectionString)
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      // механизм по умолчанию
      //Database.SetInitializer(new CreateDatabaseIfNotExists<BooksLibraryContext>());
      //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<BooksLibraryContext>());
      //Database.SetInitializer(new DropCreateDatabaseAlways<BooksLibraryContext>());
     // Database.SetInitializer(new DropDatabaseAlwaysAndInitialize());
    }


    public DbSet<BookInfo> Books { get; set; }
    public DbSet<PublisherInfo> Publishers { get; set; }
    public DbSet<AuthorInfo> Authors { get; set; }
    public DbSet<AuthorIndentity> AuthorIndentities { get; set; }
  }
}
