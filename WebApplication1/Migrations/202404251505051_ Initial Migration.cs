namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                {
                    Id = c.String(nullable: false, maxLength: 128),
                    Name = c.String(nullable: false, maxLength: 256),
                })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");

            CreateTable(
               "dbo.AspNetUserRoles",
               c => new
               {
                   UserId = c.String(nullable: false, maxLength: 128),
                   RoleId = c.String(nullable: false, maxLength: 128),
               })
               .PrimaryKey(t => new { t.UserId, t.RoleId })
               .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
               .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
               .Index(t => t.UserId)
               .Index(t => t.RoleId);

            CreateTable(
               "dbo.AspNetUsers",
               c => new
               {
                   Id = c.String(nullable: false, maxLength: 128),
                   Email = c.String(maxLength: 256),
                   EmailConfirmed = c.Boolean(nullable: false),
                   PasswordHash = c.String(),
                   SecurityStamp = c.String(),
                   PhoneNumber = c.String(),
                   PhoneNumberConfirmed = c.Boolean(nullable: false),
                   TwoFactorEnabled = c.Boolean(nullable: false),
                   LockoutEndDateUtc = c.DateTime(),
                   LockoutEnabled = c.Boolean(nullable: false),
                   AccessFailedCount = c.Int(nullable: false),
                   UserName = c.String(nullable: false, maxLength: 256),
               })
               .PrimaryKey(t => t.Id)
               .Index(t => t.UserName, unique: true, name: "UserNameIndex");

            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    UserId = c.String(nullable: false, maxLength: 128),
                    ClaimType = c.String(),
                    ClaimValue = c.String(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);

            CreateTable(
    "dbo.AspNetUserLogins",
    c => new
    {
        LoginProvider = c.String(nullable: false, maxLength: 128),
        ProviderKey = c.String(nullable: false, maxLength: 128),
        UserId = c.String(nullable: false, maxLength: 128),
    })
    .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
    .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
    .Index(t => t.UserId);


            CreateTable(
                "dbo.Cooperatives",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        CreatedAt = c.DateTime(),
                        UpdatedAt = c.DateTime(),
                        DeletedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Farms",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        CreatedAt = c.DateTime(),
                        UpdatedAt = c.DateTime(),
                        Code = c.String(),
                        VillageId = c.Guid(nullable: false),
                        FarmSubstatusId = c.Guid(),
                        CooperativeId = c.Guid(),
                        OwnershipTypeId = c.Guid(),
                        DeletedAt = c.DateTime(),
                        SupplyChainId = c.Guid(),
                        FarmStatusId = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cooperatives", t => t.CooperativeId)
                .ForeignKey("dbo.FarmStatus", t => t.FarmStatusId)
                .ForeignKey("dbo.FarmSubstatus", t => t.FarmSubstatusId)
                .ForeignKey("dbo.OwnershipTypes", t => t.OwnershipTypeId)
                .ForeignKey("dbo.Villages", t => t.VillageId, cascadeDelete: true)
                .ForeignKey("dbo.SupplyChains", t => t.SupplyChainId)
                .Index(t => t.VillageId)
                .Index(t => t.FarmSubstatusId)
                .Index(t => t.CooperativeId)
                .Index(t => t.OwnershipTypeId)
                .Index(t => t.SupplyChainId)
                .Index(t => t.FarmStatusId);
            
            CreateTable(
                "dbo.FarmStatus",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        CreatedAt = c.DateTime(),
                        UpdatedAt = c.DateTime(),
                        DeletedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FarmSubstatus",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        FarmStatusId = c.Guid(nullable: false),
                        CreatedAt = c.DateTime(),
                        UpdatedAt = c.DateTime(),
                        DeletedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FarmStatus", t => t.FarmStatusId, cascadeDelete: true)
                .Index(t => t.FarmStatusId);
            
            CreateTable(
                "dbo.OwnershipTypes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        CreatedAt = c.DateTime(),
                        UpdatedAt = c.DateTime(),
                        DeletedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SupplyChains",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        SupplierId = c.Guid(nullable: false),
                        CreatedAt = c.DateTime(),
                        UpdatedAt = c.DateTime(),
                        DeletedAt = c.DateTime(),
                        QualityProfileId = c.Guid(),
                        SupplyChainStatusId = c.Guid(),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Potencial = c.Double(nullable: false),
                        Bags = c.Double(nullable: false),
                        DepartmentId = c.Guid(nullable: false),
                        Code = c.Int(nullable: false),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: true)
                .ForeignKey("dbo.QualityProfiles", t => t.QualityProfileId)
                .ForeignKey("dbo.Suppliers", t => t.SupplierId, cascadeDelete: true)
                .ForeignKey("dbo.SupplyChainStatus", t => t.SupplyChainStatusId)
                .Index(t => t.SupplierId)
                .Index(t => t.QualityProfileId)
                .Index(t => t.SupplyChainStatusId)
                .Index(t => t.DepartmentId);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        CreatedAt = c.DateTime(),
                        UpdatedAt = c.DateTime(),
                        DeletedAt = c.DateTime(),
                        Code = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Municipalities",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        DepartmentId = c.Guid(nullable: false),
                        CreatedAt = c.DateTime(),
                        UpdatedAt = c.DateTime(),
                        DeletedAt = c.DateTime(),
                        Code = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: true)
                .Index(t => t.DepartmentId);
            
            CreateTable(
                "dbo.Villages",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        MunicipalityId = c.Guid(nullable: false),
                        CreatedAt = c.DateTime(),
                        UpdatedAt = c.DateTime(),
                        DeletedAt = c.DateTime(),
                        Code = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Municipalities", t => t.MunicipalityId, cascadeDelete: true)
                .Index(t => t.MunicipalityId);
            
            CreateTable(
                "dbo.QualityProfiles",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        CreatedAt = c.DateTime(),
                        UpdatedAt = c.DateTime(),
                        DeletedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        CountryId = c.Guid(nullable: false),
                        CreatedAt = c.DateTime(),
                        UpdatedAt = c.DateTime(),
                        DeletedAt = c.DateTime(),
                        LogoUrl = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: true)
                .Index(t => t.CountryId);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        CreatedAt = c.DateTime(),
                        UpdatedAt = c.DateTime(),
                        DeletedAt = c.DateTime(),
                        Code = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SupplyChainStatus",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        CreatedAt = c.DateTime(),
                        UpdatedAt = c.DateTime(),
                        DeletedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.SupplyChains", "SupplyChainStatusId", "dbo.SupplyChainStatus");
            DropForeignKey("dbo.SupplyChains", "SupplierId", "dbo.Suppliers");
            DropForeignKey("dbo.Suppliers", "CountryId", "dbo.Countries");
            DropForeignKey("dbo.SupplyChains", "QualityProfileId", "dbo.QualityProfiles");
            DropForeignKey("dbo.Farms", "SupplyChainId", "dbo.SupplyChains");
            DropForeignKey("dbo.SupplyChains", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.Villages", "MunicipalityId", "dbo.Municipalities");
            DropForeignKey("dbo.Farms", "VillageId", "dbo.Villages");
            DropForeignKey("dbo.Municipalities", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.Farms", "OwnershipTypeId", "dbo.OwnershipTypes");
            DropForeignKey("dbo.FarmSubstatus", "FarmStatusId", "dbo.FarmStatus");
            DropForeignKey("dbo.Farms", "FarmSubstatusId", "dbo.FarmSubstatus");
            DropForeignKey("dbo.Farms", "FarmStatusId", "dbo.FarmStatus");
            DropForeignKey("dbo.Farms", "CooperativeId", "dbo.Cooperatives");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Suppliers", new[] { "CountryId" });
            DropIndex("dbo.Villages", new[] { "MunicipalityId" });
            DropIndex("dbo.Municipalities", new[] { "DepartmentId" });
            DropIndex("dbo.SupplyChains", new[] { "DepartmentId" });
            DropIndex("dbo.SupplyChains", new[] { "SupplyChainStatusId" });
            DropIndex("dbo.SupplyChains", new[] { "QualityProfileId" });
            DropIndex("dbo.SupplyChains", new[] { "SupplierId" });
            DropIndex("dbo.FarmSubstatus", new[] { "FarmStatusId" });
            DropIndex("dbo.Farms", new[] { "FarmStatusId" });
            DropIndex("dbo.Farms", new[] { "SupplyChainId" });
            DropIndex("dbo.Farms", new[] { "OwnershipTypeId" });
            DropIndex("dbo.Farms", new[] { "CooperativeId" });
            DropIndex("dbo.Farms", new[] { "FarmSubstatusId" });
            DropIndex("dbo.Farms", new[] { "VillageId" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.SupplyChainStatus");
            DropTable("dbo.Countries");
            DropTable("dbo.Suppliers");
            DropTable("dbo.QualityProfiles");
            DropTable("dbo.Villages");
            DropTable("dbo.Municipalities");
            DropTable("dbo.Departments");
            DropTable("dbo.SupplyChains");
            DropTable("dbo.OwnershipTypes");
            DropTable("dbo.FarmSubstatus");
            DropTable("dbo.FarmStatus");
            DropTable("dbo.Farms");
            DropTable("dbo.Cooperatives");
        }
    }
}
