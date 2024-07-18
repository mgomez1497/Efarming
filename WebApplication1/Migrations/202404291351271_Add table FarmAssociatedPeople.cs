namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddtableFarmAssociatedPeople : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FarmAssociatedPeoples",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        FarmId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserId, t.FarmId })
                .ForeignKey("dbo.Farms", t => t.FarmId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.FarmId);
            
            CreateTable(
                "dbo.ApplicationUserFarms",
                c => new
                    {
                        ApplicationUser_Id = c.String(nullable: false, maxLength: 128),
                        Farm_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.ApplicationUser_Id, t.Farm_Id })
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id, cascadeDelete: true)
                .ForeignKey("dbo.Farms", t => t.Farm_Id, cascadeDelete: true)
                .Index(t => t.ApplicationUser_Id)
                .Index(t => t.Farm_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FarmAssociatedPeoples", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.FarmAssociatedPeoples", "FarmId", "dbo.Farms");
            DropForeignKey("dbo.ApplicationUserFarms", "Farm_Id", "dbo.Farms");
            DropForeignKey("dbo.ApplicationUserFarms", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.ApplicationUserFarms", new[] { "Farm_Id" });
            DropIndex("dbo.ApplicationUserFarms", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.FarmAssociatedPeoples", new[] { "FarmId" });
            DropIndex("dbo.FarmAssociatedPeoples", new[] { "UserId" });
            DropTable("dbo.ApplicationUserFarms");
            DropTable("dbo.FarmAssociatedPeoples");
        }
    }
}
