namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addtableFamilyUnitMembers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FamilyUnitMembers",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Age = c.DateTime(nullable: false),
                        Identification = c.String(),
                        Education = c.String(),
                        PhoneNumber = c.String(),
                        Relationship = c.String(),
                        MaritalStatus = c.String(),
                        IsOwner = c.Boolean(nullable: false),
                        FarmId = c.Guid(nullable: false),
                        CreatedAt = c.DateTime(),
                        UpdatedAt = c.DateTime(),
                        DeletedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Farms", t => t.FarmId, cascadeDelete: true)
                .Index(t => t.FarmId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FamilyUnitMembers", "FarmId", "dbo.Farms");
            DropIndex("dbo.FamilyUnitMembers", new[] { "FarmId" });
            DropTable("dbo.FamilyUnitMembers");
        }
    }
}
