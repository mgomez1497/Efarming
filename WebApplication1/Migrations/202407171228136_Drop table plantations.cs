namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Droptableplantations : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Plantations");
        }
        
        public override void Down()
        {
        }
    }
}
