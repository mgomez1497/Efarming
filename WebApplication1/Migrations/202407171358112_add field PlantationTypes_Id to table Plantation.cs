namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addfieldPlantationTypes_IdtotablePlantation : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Plantation", "PlantationTypes_Id", "dbo.PlantationTypes");
            DropIndex("dbo.Plantation", new[] { "PlantationTypes_Id" });
            AddColumn("dbo.Plantation", "PlantationTypes_Id1", c => c.Guid());
            CreateIndex("dbo.Plantation", "PlantationTypes_Id1");
            AddForeignKey("dbo.Plantation", "PlantationTypes_Id1", "dbo.PlantationTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Plantation", "PlantationTypes_Id1", "dbo.PlantationTypes");
            DropIndex("dbo.Plantation", new[] { "PlantationTypes_Id1" });
            DropColumn("dbo.Plantation", "PlantationTypes_Id1");
            CreateIndex("dbo.Plantation", "PlantationTypes_Id");
            AddForeignKey("dbo.Plantation", "PlantationTypes_Id", "dbo.PlantationTypes", "Id");
        }
    }
}
