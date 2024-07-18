namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatetableplantations : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Plantations", "PlantationTypes_Id", "dbo.PlantationTypes");
            DropIndex("dbo.Plantations", new[] { "PlantationTypes_Id" });
            DropForeignKey("dbo.Plantations", "PlantationStatuses_Id", "dbo.PlantationTypes");
            DropIndex("dbo.Plantations", new[] { "PlantationStatuses_Id" });
            DropForeignKey("dbo.Plantations", "PlantationVarieties_Id", "dbo.PlantationTypes");
            DropIndex("dbo.Plantations", new[] { "PlantationVarieties_Id" });

            AddColumn("dbo.Plantations", "PlantationTypeId", c => c.Guid());
            CreateIndex("dbo.Plantations", "PlantationTypeId");
            AddForeignKey("dbo.Plantations", "PlantationTypeId", "dbo.PlantationTypes", "Id");

            AddColumn("dbo.Plantations", "PlantationStatusId", c => c.Guid());
            CreateIndex("dbo.Plantations", "PlantationStatusId");
            AddForeignKey("dbo.Plantations", "PlantationStatusId", "dbo.PlantationStatuses", "Id");

            AddColumn("dbo.Plantations", "PlantationVarietyId", c => c.Guid());
            CreateIndex("dbo.Plantations", "PlantationVarietyId");
            AddForeignKey("dbo.Plantations", "PlantationVarietyId", "dbo.PlantationVarieties", "Id");
        }
        
        public override void Down()
        {


        
        }
    }
}
