namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatetableplanationsTypeId3 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Plantations", "PlantationTypes_Id");
            RenameColumn(table: "dbo.Plantations", name: "PlantationTypes_Id1", newName: "PlantationTypes_Id");
            RenameIndex(table: "dbo.Plantations", name: "IX_PlantationTypes_Id1", newName: "IX_PlantationTypes_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Plantations", name: "IX_PlantationTypes_Id", newName: "IX_PlantationTypes_Id1");
            RenameColumn(table: "dbo.Plantations", name: "PlantationTypes_Id", newName: "PlantationTypes_Id1");
            AddColumn("dbo.Plantations", "PlantationTypes_Id", c => c.Guid());
        }
    }
}
