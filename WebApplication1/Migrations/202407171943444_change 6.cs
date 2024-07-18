namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change6 : DbMigration
    {
        public override void Up()
        {
            
            DropIndex("dbo.SustainabilityContactFarms", new[] { "ContactId" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.SustainabilityContactFarms", "ContactId");
            AddForeignKey("dbo.SustainabilityContactFarms", "ContactId", "dbo.SustainabilityContacts", "Id", cascadeDelete: true);
        }
    }
}
