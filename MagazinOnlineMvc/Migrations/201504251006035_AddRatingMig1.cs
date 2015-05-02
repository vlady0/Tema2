namespace MagazinOnlineMvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRatingMig1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "name", c => c.String());
        }
    }
}
