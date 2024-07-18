namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropColumn : DbMigration
    {
        public override void Up()
        {
            
            DropColumn("dbo.Plantation", "PlantationTypes_Id");
           
        }
        
        public override void Down()
        {
            AddColumn("dbo.Plantation", "PlantationTypes_Id", c => c.Guid());
        }
    }
}
