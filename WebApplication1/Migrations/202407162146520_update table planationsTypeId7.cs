namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatetableplanationsTypeId7 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Plantations", " PlantationTypes_Id");
            DropColumn("dbo.Plantations", "prueba");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Plantations", "prueba", c => c.String());
            AddColumn("dbo.Plantations", " PlantationTypes_Id", c => c.Guid());
        }
    }
}
