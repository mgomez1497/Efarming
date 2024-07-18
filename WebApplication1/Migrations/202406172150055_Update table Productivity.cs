namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatetableProductivity : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Productivities", "Id", "dbo.Farms");
            DropIndex("dbo.Productivities", new[] { "Id" });
            AlterColumn("dbo.Productivities", "TotalHectares", c => c.String(maxLength: 20));
            AlterColumn("dbo.Productivities", "ForestProtectedHectares", c => c.String(maxLength: 20));
            AlterColumn("dbo.Productivities", "ConservationHectares", c => c.String(maxLength: 20));
            AlterColumn("dbo.Productivities", "ShadingPercentage", c => c.String(maxLength: 20));
            AlterColumn("dbo.Productivities", "InfrastructureHectares", c => c.String(maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Productivities", "InfrastructureHectares", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Productivities", "ShadingPercentage", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Productivities", "ConservationHectares", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Productivities", "ForestProtectedHectares", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Productivities", "TotalHectares", c => c.String(nullable: false, maxLength: 20));
            CreateIndex("dbo.Productivities", "Id");
            AddForeignKey("dbo.Productivities", "Id", "dbo.Farms", "Id");
        }
    }
}
