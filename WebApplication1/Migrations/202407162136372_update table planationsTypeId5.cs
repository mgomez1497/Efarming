namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatetableplanationsTypeId5 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Plantations", "prueba");
        }
        
        public override void Down()
        {
        }
    }
}
