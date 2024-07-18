namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatetableSustainabilityContacts : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SustainabilityContacts", "SustainabilityContacts_Id", "dbo.SustainabilityContacts");
            DropIndex("dbo.SustainabilityContacts", new[] { "SustainabilityContacts_Id" });
        }
        
        public override void Down()
        {
        }
    }
}
