namespace DvdClub.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReviewP1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.KRATHSH", "DateRented", c => c.DateTime(nullable: false));
            AddColumn("dbo.KRATHSH", "ExpectedReturnDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.KRATHSH", "ActualReturnDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.KRATHSH", "SomeDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.KRATHSH", "SomeDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.KRATHSH", "ActualReturnDate");
            DropColumn("dbo.KRATHSH", "ExpectedReturnDate");
            DropColumn("dbo.KRATHSH", "DateRented");
        }
    }
}
