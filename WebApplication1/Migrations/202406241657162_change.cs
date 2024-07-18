namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Plantations", "PlantationStatuses_Id", "dbo.PlantationStatuses");
            DropForeignKey("dbo.Plantations", "PlantationVarieties_Id", "dbo.PlantationVarieties");
            DropIndex("dbo.Plantations", new[] { "PlantationStatuses_Id" });
            DropIndex("dbo.Plantations", new[] { "PlantationVarieties_Id" });
            DropColumn("dbo.Plantations", "PlantationStatuses_Id");
            DropColumn("dbo.Plantations", "PlantationVarieties_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Plantations", "PlantationVarieties_Id", c => c.Guid());
            AddColumn("dbo.Plantations", "PlantationStatuses_Id", c => c.Guid());
            CreateIndex("dbo.Plantations", "PlantationVarieties_Id");
            CreateIndex("dbo.Plantations", "PlantationStatuses_Id");
            AddForeignKey("dbo.Plantations", "PlantationVarieties_Id", "dbo.PlantationVarieties", "Id");
            AddForeignKey("dbo.Plantations", "PlantationStatuses_Id", "dbo.PlantationStatuses", "Id");
        }
    }
}
