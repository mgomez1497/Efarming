namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class prueba2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PlantationVarieties", "PlantationTypes_Id1", "dbo.PlantationTypes");
            DropIndex("dbo.PlantationVarieties", new[] { "PlantationTypes_Id" });
            CreateIndex("dbo.PlantationVarieties", "PlantationTypes_Id");
            AddForeignKey("dbo.PlantationVarieties", "PlantationTypes_Id", "dbo.PlantationTypes", "Id");
        }
        
        public override void Down()
        {
        }
    }
}
