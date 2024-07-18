namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Droptable : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Plants");
        }
        
        public override void Down()
        {
        }
    }
}
