namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class prueba : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PlantationVarieties", "PlantationTypes_Id", "dbo.PlantationTypes");
            DropIndex("dbo.PlantationVarieties", new[] { "PlantationTypes_Id" });
            AddColumn("dbo.PlantationVarieties", "PlantationTypes_Id1", c => c.Guid());
            CreateIndex("dbo.PlantationVarieties", "PlantationTypes_Id1");
            AddForeignKey("dbo.PlantationVarieties", "PlantationTypes_Id1", "dbo.PlantationTypes", "Id");
            DropColumn("dbo.PlantationVarieties", "PlantationTypeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PlantationVarieties", "PlantationTypeId", c => c.Guid());
            DropForeignKey("dbo.PlantationVarieties", "PlantationTypes_Id1", "dbo.PlantationTypes");
            DropIndex("dbo.PlantationVarieties", new[] { "PlantationTypes_Id1" });
            DropColumn("dbo.PlantationVarieties", "PlantationTypes_Id1");
            CreateIndex("dbo.PlantationVarieties", "PlantationTypes_Id");
            AddForeignKey("dbo.PlantationVarieties", "PlantationTypes_Id", "dbo.PlantationTypes", "Id");
        }
    }
}
