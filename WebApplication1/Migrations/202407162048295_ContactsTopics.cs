namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ContactsTopics : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SustainabilityContactTopic",
                c => new
                    {
                        ContactId = c.Guid(nullable: false),
                        TopicId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ContactId, t.TopicId })
                .ForeignKey("dbo.SustainabilityContacts", t => t.ContactId, cascadeDelete: true)
                .ForeignKey("dbo.SustainabilityContactTopics", t => t.TopicId, cascadeDelete: true)
                .Index(t => t.ContactId)
                .Index(t => t.TopicId);
            
            CreateTable(
                "dbo.SustainabilityContactTopics",
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
            DropForeignKey("dbo.SustainabilityContactTopic", "TopicId", "dbo.SustainabilityContactTopics");
            DropForeignKey("dbo.SustainabilityContactTopic", "ContactId", "dbo.SustainabilityContacts");
            DropIndex("dbo.SustainabilityContactTopic", new[] { "TopicId" });
            DropIndex("dbo.SustainabilityContactTopic", new[] { "ContactId" });
            DropTable("dbo.SustainabilityContactTopics");
            DropTable("dbo.SustainabilityContactTopic");
        }
    }
}
