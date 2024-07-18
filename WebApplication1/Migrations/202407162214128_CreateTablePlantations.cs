namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTablePlantations : DbMigration
    {
        public override void Up()
        {
            CreateTable(
               "dbo.Plantations",
               c => new
               {
                   Id = c.Guid(nullable: false),
                   Hectares = c.String(),
                   EstimatedProduction = c.String(),
                   Age = c.DateTime(),
                   NumberOfPlants = c.Int(nullable: false),
                   PlantationStatusId = c.Guid(),
                   ProductivityId = c.Guid(),
                   PlantationTypeId = c.Guid(),
                   PlantationVarietyId = c.Guid(),
                   CreatedAt = c.DateTime(),
                   UpdatedAt = c.DateTime(),
                   DeletedAt = c.DateTime(),
                   TreesDistance = c.String(),
                   GrooveDistance = c.String(),
                   Density = c.String(),
                   NumberLot = c.Int(nullable: false),
                   NomLot = c.String(),
                   LabLot = c.String(),
                   TipoLot = c.String(),
                   FormLot = c.String(),
                   NumEjeArbLot = c.Int(nullable: false),

               })
               .PrimaryKey(t => t.Id)
               .ForeignKey("dbo.PlantationStatuses", t => t.PlantationStatusId)
               .ForeignKey("dbo.PlantationTypes", t => t.PlantationTypeId)
               .ForeignKey("dbo.PlantationVarieties", t => t.PlantationVarietyId)
               .ForeignKey("dbo.Productivities", t => t.ProductivityId)
               .Index(t => t.ProductivityId)
               .Index(t => t.PlantationStatusId)
               .Index(t => t.PlantationTypeId)
               .Index(t => t.PlantationVarietyId);
        }
        
        public override void Down()
        {
        }
    }
}
