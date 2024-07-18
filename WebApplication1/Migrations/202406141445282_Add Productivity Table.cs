namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProductivityTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Productivities",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        TotalHectares = c.String(nullable: false, maxLength: 20),
                        ForestProtectedHectares = c.String(nullable: false, maxLength: 20),
                        ConservationHectares = c.String(nullable: false, maxLength: 20),
                        ShadingPercentage = c.String(nullable: false, maxLength: 20),
                        CreatedAt = c.DateTime(),
                        UpdatedAt = c.DateTime(),
                        InfrastructureHectares = c.String(nullable: false, maxLength: 20),
                        DeletedAt = c.DateTime(),
                        AverageAge = c.Double(nullable: false),
                        AverageDensity = c.String(maxLength: 20),
                        PercentageColombia = c.Double(nullable: false),
                        PercentageCaturra = c.Double(nullable: false),
                        PercentageCastillo = c.Double(nullable: false),
                        PercentageOtra = c.Double(nullable: false),
                        CoffeeArea = c.String(maxLength: 20),
                        ProductionPlants = c.Double(nullable: false),
                        ProductionPercentage = c.Double(nullable: false),
                        GrowingPlants = c.Double(nullable: false),
                        GrowingPercentage = c.Double(nullable: false),
                        EstimatedProduction = c.Double(nullable: false),
                        ProductionAreaPercentage = c.Double(nullable: false),
                        GrowingAreaPercentage = c.Double(nullable: false),
                        ProductionArea = c.String(maxLength: 20),
                        GrowingArea = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Farms", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Productivities", "Id", "dbo.Farms");
            DropIndex("dbo.Productivities", new[] { "Id" });
            DropTable("dbo.Productivities");
        }
    }
}
