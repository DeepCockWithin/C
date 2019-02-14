namespace BooksLibrary.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthDayNameAuthord : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Authors", "Security", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Authors", "Security");
        }
    }
}
