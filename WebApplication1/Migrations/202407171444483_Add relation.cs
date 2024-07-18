namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addrelation : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Plantation", "PlantationTypes_Id1", "dbo.PlantationTypes");
            DropIndex("dbo.Plantation", new[] { "PlantationTypes_Id1" });
            
        }
        
        public override void Down()
        {
            AddColumn("dbo.Plantation", "PlantationTypes_Id1", c => c.Guid());
            CreateIndex("dbo.Plantation", "PlantationTypes_Id1");
            AddForeignKey("dbo.Plantation", "PlantationTypes_Id1", "dbo.PlantationTypes", "Id");
        }
    }
}

