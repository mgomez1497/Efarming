namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class droprelations : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Plants", "PlantationStatusId", "dbo.PlantationStatuses");
            DropForeignKey("dbo.Plants", "PlantationTypeId", "dbo.PlantationTypes");
            DropForeignKey("dbo.Plants", "PlantationVarietyId", "dbo.PlantationVarieties");
            DropForeignKey("dbo.Plants", "ProductivityId", "dbo.Productivities");

            DropIndex("dbo.Plants", new[] { "PlantationStatusId" });
            DropIndex("dbo.Plants", new[] { "ProductivityId" });
            DropIndex("dbo.Plants", new[] { "PlantationTypeId" });
            DropIndex("dbo.Plants", new[] { "PlantationVarietyId" });
        }

        public override void Down()
        {
            // Revertir las operaciones en caso de que se necesite
            CreateIndex("dbo.Plants", "PlantationVarietyId");
            CreateIndex("dbo.Plants", "PlantationTypeId");
            CreateIndex("dbo.Plants", "ProductivityId");
            CreateIndex("dbo.Plants", "PlantationStatusId");

            AddForeignKey("dbo.Plants", "ProductivityId", "dbo.Productivities", "Id");
            AddForeignKey("dbo.Plants", "PlantationVarietyId", "dbo.PlantationVarieties", "Id");
            AddForeignKey("dbo.Plants", "PlantationTypeId", "dbo.PlantationTypes", "Id");
            AddForeignKey("dbo.Plants", "PlantationStatusId", "dbo.PlantationStatuses", "Id");
        }
    }
}
