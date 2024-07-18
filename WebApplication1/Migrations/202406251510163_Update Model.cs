namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Plantations", "PlantationTypes_Id", "dbo.PlantationTypes");
            DropIndex("dbo.Plantations", new[] { "PlantationTypes_Id" });
            AddColumn("dbo.Plantations", "PlantationTypes_Id1", c => c.Guid());
            CreateIndex("dbo.Plantations", "PlantationTypes_Id1");
            AddForeignKey("dbo.Plantations", "PlantationTypes_Id1", "dbo.PlantationTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Plantations", "PlantationTypes_Id1", "dbo.PlantationTypes");
            DropIndex("dbo.Plantations", new[] { "PlantationTypes_Id1" });
            DropColumn("dbo.Plantations", "PlantationTypes_Id1");
            CreateIndex("dbo.Plantations", "PlantationTypes_Id");
            AddForeignKey("dbo.Plantations", "PlantationTypes_Id", "dbo.PlantationTypes", "Id");
        }
    }
}
