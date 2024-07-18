namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateModel4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Plantations", "PlantationTypes_Id", "dbo.PlantationTypes");
            DropIndex("dbo.Plantations", new[] { "PlantationTypes_Id" });
            DropColumn("dbo.Plantations", "PlantationTypes_Id");
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Plantations", "PlantationTypes_Id", "dbo.PlantationTypes");
            DropIndex("dbo.Plantations", new[] { "PlantationTypes_Id" });
            DropColumn("dbo.Plantations", "PlantationTypes_Id");
        }
    }
}
