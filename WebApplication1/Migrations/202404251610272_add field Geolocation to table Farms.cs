namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Spatial;
    
    public partial class addfieldGeolocationtotableFarms : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Farms", "Geolocation", c => c.Geography());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Farms", "Geolocation");
        }
    }
}
