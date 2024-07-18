namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change1 : DbMigration
    {
        public override void Up()
        {
            
            DropIndex("dbo.SustainabilityContactTopics1", new[] { "ContactId" });
            DropIndex("dbo.SustainabilityContactTopics1", new[] { "TopicId" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.SustainabilityContactTopics1", "TopicId");
            CreateIndex("dbo.SustainabilityContactTopics1", "ContactId");
            AddForeignKey("dbo.SustainabilityContactTopics1", "TopicId", "dbo.SustainabilityContactTopics", "Id", cascadeDelete: true);
            AddForeignKey("dbo.SustainabilityContactTopics1", "ContactId", "dbo.SustainabilityContacts", "Id", cascadeDelete: true);
        }
    }
}
