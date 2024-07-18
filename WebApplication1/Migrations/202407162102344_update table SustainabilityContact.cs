namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatetableSustainabilityContact : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SustainabilityContacts", "SustainabilityContacts_Id", "dbo.SustainabilityContacts");
            DropIndex("dbo.SustainabilityContacts", new[] { "SustainabilityContacts_Id" });
            DropColumn("dbo.SustainabilityContacts", "SustainabilityContacts_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SustainabilityContacts", "SustainabilityContacts_Id", c => c.Guid());
            CreateIndex("dbo.SustainabilityContacts", "SustainabilityContacts_Id");
            AddForeignKey("dbo.SustainabilityContacts", "SustainabilityContacts_Id", "dbo.SustainabilityContacts", "Id");
        }
    }
}
