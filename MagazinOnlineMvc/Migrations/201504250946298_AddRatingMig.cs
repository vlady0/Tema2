namespace MagazinOnlineMvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRatingMig : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "numberOfProducts", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "numberOfProducts");
        }
    }
}
