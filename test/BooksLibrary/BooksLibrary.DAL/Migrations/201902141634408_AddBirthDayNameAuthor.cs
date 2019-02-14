namespace BooksLibrary.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthDayNameAuthor : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.AuthorInfoes", newName: "Authors");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Authors", newName: "AuthorInfoes");
        }
    }
}
