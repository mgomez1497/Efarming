namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenamePlantationTypeIdColumn : DbMigration
    {
             public override void Up()
        {
            RenameColumn(table: "dbo.Plantation", name: "PlantationTypes_Id1", newName: "PlantationTypes_Id");
            
            RenameIndex(table: "dbo.Plantation", name: "IX_PlantationTypes_Id1", newName: "IX_PlantationTypes_Id");
        }

        public override void Down()
        {
            RenameColumn(table: "dbo.Plantation", name: "PlantationTypes_Id", newName: "PlantationTypes_Id1");
            RenameIndex(table: "dbo.Plantation", name: "IX_PlantationTypes_Id", newName: "IX_PlantationTypes_Id1");
        }
    }
        
        
}
