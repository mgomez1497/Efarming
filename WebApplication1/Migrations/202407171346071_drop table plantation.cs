namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class droptableplantation : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Plantations", newName: "Plantation");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Plantation", newName: "Plantations");
        }
    }
}
