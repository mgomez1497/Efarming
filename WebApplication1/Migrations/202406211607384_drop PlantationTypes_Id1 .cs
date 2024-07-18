namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dropPlantationTypes_Id1 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.PlantationVarieties", new[] { "PlantationTypes_Id1" });
            DropColumn("dbo.PlantationVarieties", "PlantationTypes_Id1");
        }
        
        public override void Down()
        {
        }
    }
}
