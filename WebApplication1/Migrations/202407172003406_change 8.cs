namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change8 : DbMigration
    {
        public override void Up()
        {
            
            DropIndex("dbo.SustainabilityContacts", new[] { "SustainabilityContactsLocations_Id" });
  
        }
        
        public override void Down()
        {
            AddColumn("dbo.SustainabilityContacts", "SustainabilityContactsLocations_Id", c => c.Int());
            CreateIndex("dbo.SustainabilityContacts", "SustainabilityContactsLocations_Id");
            AddForeignKey("dbo.SustainabilityContacts", "SustainabilityContactsLocations_Id", "dbo.SustainabilityContactsLocations", "Id");
        }
    }
}
