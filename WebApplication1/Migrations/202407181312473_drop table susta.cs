namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class droptablesusta : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.SustainabilityContactTopics1");
        }
        
        public override void Down()
        {
        }
    }
}
