namespace DvdClub.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReviewP11 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.KRATHSH", "ActualReturnDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.KRATHSH", "ActualReturnDate", c => c.DateTime(nullable: false));
        }
    }
}
