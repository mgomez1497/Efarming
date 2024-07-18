namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change7 : DbMigration
    {
        public override void Up()
        {
            
            DropIndex("dbo.SustainabilityContacts", new[] { "LocationId" });
            DropIndex("dbo.SustainabilityContacts", new[] { "TypeId" });
            DropIndex("dbo.SustainabilityContacts", new[] { "UserId" });
           
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SustainabilityContacts", "SustainabilityContactsLocations_Id", "dbo.SustainabilityContactsLocations");
            DropIndex("dbo.SustainabilityContacts", new[] { "SustainabilityContactsLocations_Id" });
            AlterColumn("dbo.SustainabilityContacts", "UserId", c => c.String(maxLength: 128));
            DropColumn("dbo.SustainabilityContacts", "SustainabilityContactsLocations_Id");
            CreateIndex("dbo.SustainabilityContacts", "UserId");
            CreateIndex("dbo.SustainabilityContacts", "TypeId");
            CreateIndex("dbo.SustainabilityContacts", "LocationId");
            AddForeignKey("dbo.SustainabilityContacts", "LocationId", "dbo.SustainabilityContactsLocations", "Id", cascadeDelete: true);
            AddForeignKey("dbo.SustainabilityContacts", "UserId", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.SustainabilityContacts", "TypeId", "dbo.SustainabilityContactsTypes", "Id", cascadeDelete: true);
        }
    }
}
