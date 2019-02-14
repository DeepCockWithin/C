using BooksLibrary.DAL.Context;
using BooksLibrary.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace BooksLibrary.DAL.Initializators
{
  public class DropDatabaseAlwaysAndInitialize : DropCreateDatabaseAlways<BooksLibraryContext>
  {
    protected override void Seed(BooksLibraryContext context)
    {
      base.Seed(context);

      AuthorIndentity authorIndentity = new AuthorIndentity()
      {
        Login="C#", Password=".NET"
      };

      AuthorInfo author = new AuthorInfo()
      {
        AuthorIndentity = authorIndentity,
        LastName="Richter",
      };

      PublisherInfo publisher = new PublisherInfo()
      {
        Name= "Grn LLC"
      };

      BookInfo book = new BookInfo()
      {
        Title="CLR via C#",
        Date = new DateTime(2018,10,10),
        Price=5000,
        PublisherInfo = publisher
      };
      book.Authors = new List<AuthorInfo>() { author };

      context.Books.Add(book);
      context.SaveChanges();

    }
  }
}
