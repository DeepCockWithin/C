using BooksLibrary.DAL.Context;
using BooksLibrary.DAL.Entities;
using System.Linq;
using static System.Console;

namespace BooksLibrary.PL.Console
{
  class Program
  {
    static void Main(string[] args)
    {
      using (BooksLibraryContext db = new BooksLibraryContext())
      {
         var coll=    db.Database.SqlQuery<AuthorInfo>("select * from Authors").ToList();
      
        int countBooks = db.Books.Count();
        WriteLine($"countBooks:{countBooks}");

        var books = db.Books;

        foreach (var book in books)
        {
          WriteLine($"Title: {book.Title}, PublishName: {book.PublisherInfo.Name}");

          foreach (var author in book.Authors)
          {
            WriteLine($"Name: {author.LastName}, Login: {author.AuthorIndentity.Login}");
          }
        }


      }

      ReadKey();
    }
  }
}
