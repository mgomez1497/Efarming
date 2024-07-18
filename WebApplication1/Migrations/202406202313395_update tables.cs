namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatetables : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Plantations", "PlantationTypeId");
            DropColumn("dbo.Plantations", "PlantationVarietyId");
            DropColumn("dbo.Plantations", "PlantationStatusId");
            DropColumn("dbo.PlantationVarieties", "PlantationTypeId");
        }
        
        public override void Down()
        {
        }
    }
}
