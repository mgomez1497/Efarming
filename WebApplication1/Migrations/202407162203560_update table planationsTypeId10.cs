namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatetableplanationsTypeId10 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Plantations", new[] { "PlantationTypes_Id" });
        }
        
        public override void Down()
        {

        }
    }
}
