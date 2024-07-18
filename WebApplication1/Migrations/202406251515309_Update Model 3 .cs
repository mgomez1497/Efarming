namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateModel3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Plantations", "PlantationTypes_Id", c => c.Guid());
            CreateIndex("dbo.Plantations", "PlantationTypes_Id");
            AddForeignKey("dbo.Plantations", "PlantationTypes_Id", "dbo.PlantationTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Plantations", "PlantationTypes_Id", "dbo.PlantationTypes");
            DropIndex("dbo.Plantations", new[] { "PlantationTypes_Id" });
            DropColumn("dbo.Plantations", "PlantationTypes_Id");


        }
    }
}
