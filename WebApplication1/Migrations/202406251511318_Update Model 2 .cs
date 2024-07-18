namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateModel2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Plantations", "PlantationTypes_Id1", "dbo.PlantationTypes");
            DropIndex("dbo.Plantations", new[] { "PlantationTypes_Id1" });
            DropColumn("dbo.Plantations", "PlantationTypes_Id1");
        }
        
        public override void Down()
        {
        }
    }
}
