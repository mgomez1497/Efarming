namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatetableplanationsTypeId9 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Plantations", "PlantationTypes_Id1", "dbo.PlantationTypes");
            DropIndex("dbo.Plantations", new[] { "PlantationTypes_Id1" });
            DropColumn("dbo.Plantations", "PlantationTypes_Id1");
                
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Plantations", name: "IX_PlantationTypes_Id", newName: "IX_PlantationTypes_Id1");
            RenameColumn(table: "dbo.Plantations", name: "PlantationTypes_Id", newName: "PlantationTypes_Id1");
            AddColumn("dbo.Plantations", "PlantationTypes_Id", c => c.Guid());
        }
    }
}
