namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatetableplanationsTypeId6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Plantations", "prueba", c => c.String());
            AddColumn("dbo.Plantations", " PlantationTypes_Id", c => c.Guid());
        }
        
        public override void Down()
        {
        }
    }
}
