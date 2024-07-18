namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeIndex : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.SustainabilityContactTopics1", new[] { "ContactId" });
            DropIndex("dbo.SustainabilityContactTopics1", new[] { "TopicId" });
           
        }
        
        public override void Down()
        {

        }
    }
}
