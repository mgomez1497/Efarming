namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Contactstodb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SustainabilityContactFarms",
                c => new
                    {
                        ContactId = c.Guid(nullable: false),
                        FarmId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.ContactId, t.FarmId })
                .ForeignKey("dbo.SustainabilityContacts", t => t.ContactId, cascadeDelete: true)
                .ForeignKey("dbo.Farms", t => t.FarmId, cascadeDelete: true)
                .Index(t => t.ContactId)
                .Index(t => t.FarmId);
            
            CreateTable(
                "dbo.SustainabilityContacts",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Date = c.DateTime(),
                        Comment = c.String(),
                        CreatedAt = c.DateTime(),
                        UpdatedAt = c.DateTime(),
                        DeletedAt = c.DateTime(),
                        Latitude = c.String(),
                        Longitude = c.String(),
                        LocationId = c.Int(nullable: false),
                        TypeId = c.Int(nullable: false),
                        UserId = c.String(maxLength: 128),
                        SustainabilityContacts_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SustainabilityContacts", t => t.SustainabilityContacts_Id)
                .ForeignKey("dbo.SustainabilityContactsLocations", t => t.LocationId, cascadeDelete: true)
                .ForeignKey("dbo.SustainabilityContactsTypes", t => t.TypeId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.LocationId)
                .Index(t => t.TypeId)
                .Index(t => t.UserId)
                .Index(t => t.SustainabilityContacts_Id);
            
            CreateTable(
                "dbo.SustainabilityContactsLocations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        CreatedAt = c.DateTime(),
                        UpdatedAt = c.DateTime(),
                        DeletedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SustainabilityContactsTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        CreatedAt = c.DateTime(),
                        UpdatedAt = c.DateTime(),
                        DeletedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SustainabilityContactFarms", "FarmId", "dbo.Farms");
            DropForeignKey("dbo.SustainabilityContactFarms", "ContactId", "dbo.SustainabilityContacts");
            DropForeignKey("dbo.SustainabilityContacts", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.SustainabilityContacts", "TypeId", "dbo.SustainabilityContactsTypes");
            DropForeignKey("dbo.SustainabilityContacts", "LocationId", "dbo.SustainabilityContactsLocations");
            DropForeignKey("dbo.SustainabilityContacts", "SustainabilityContacts_Id", "dbo.SustainabilityContacts");
            DropIndex("dbo.SustainabilityContacts", new[] { "SustainabilityContacts_Id" });
            DropIndex("dbo.SustainabilityContacts", new[] { "UserId" });
            DropIndex("dbo.SustainabilityContacts", new[] { "TypeId" });
            DropIndex("dbo.SustainabilityContacts", new[] { "LocationId" });
            DropIndex("dbo.SustainabilityContactFarms", new[] { "FarmId" });
            DropIndex("dbo.SustainabilityContactFarms", new[] { "ContactId" });
            DropTable("dbo.SustainabilityContactsTypes");
            DropTable("dbo.SustainabilityContactsLocations");
            DropTable("dbo.SustainabilityContacts");
            DropTable("dbo.SustainabilityContactFarms");
        }
    }
}
