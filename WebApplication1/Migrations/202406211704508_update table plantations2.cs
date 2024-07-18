namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatetableplantations2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Plantations", "PlantationTypes_Id", "dbo.PlantationTypes");
            DropIndex("dbo.Plantations", new[] { "PlantationTypes_Id" });
            DropForeignKey("dbo.Plantations", "PlantationStatuses_Id", "dbo.PlantationStatuses");
            DropIndex("dbo.Plantations", new[] { "PlantationStatuses_Id" });
            DropForeignKey("dbo.Plantations", "PlantationVarieties_Id", "dbo.PlantationVarieties");
            DropIndex("dbo.Plantations", new[] { "PlantationVarieties_Id" });
            DropColumn("dbo.Plantations", "PlantationTypes_Id");
            DropColumn("dbo.Plantations", "PlantationStatuses_Id");
            DropColumn("dbo.Plantations", "PlantationVarieties_Id");
        }
        
        public override void Down()
        {
        }
    }
}
