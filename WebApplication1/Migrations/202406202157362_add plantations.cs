namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addplantations : DbMigration
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
            
            CreateTable(
                "dbo.PlantationStatuses",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        CreatedAt = c.DateTime(),
                        UpdatedAt = c.DateTime(),
                        DeletedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PlantationTypes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        CreatedAt = c.DateTime(),
                        UpdatedAt = c.DateTime(),
                        DeletedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PlantationVarieties",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        PlantationTypeId = c.Guid(),
                        CreatedAt = c.DateTime(),
                        UpdatedAt = c.DateTime(),
                        DeletedAt = c.DateTime(),
                        PlantationTypes_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PlantationTypes", t => t.PlantationTypes_Id)
                .Index(t => t.PlantationTypes_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Plantations", "ProductivityId", "dbo.Productivities");
            DropForeignKey("dbo.PlantationVarieties", "PlantationTypes_Id", "dbo.PlantationTypes");
            DropForeignKey("dbo.Plantations", "PlantationVarieties_Id", "dbo.PlantationVarieties");
            DropForeignKey("dbo.Plantations", "PlantationTypes_Id", "dbo.PlantationTypes");
            DropForeignKey("dbo.Plantations", "PlantationStatuses_Id", "dbo.PlantationStatuses");
            DropIndex("dbo.PlantationVarieties", new[] { "PlantationTypes_Id" });
            DropIndex("dbo.Plantations", new[] { "PlantationVarieties_Id" });
            DropIndex("dbo.Plantations", new[] { "PlantationTypes_Id" });
            DropIndex("dbo.Plantations", new[] { "PlantationStatuses_Id" });
            DropIndex("dbo.Plantations", new[] { "ProductivityId" });
            DropTable("dbo.PlantationVarieties");
            DropTable("dbo.PlantationTypes");
            DropTable("dbo.PlantationStatuses");
            DropTable("dbo.Plantations");
        }
    }
}
