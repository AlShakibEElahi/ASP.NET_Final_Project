namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class new_database : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BandManagers",
                c => new
                    {
                        BandManagerId = c.String(nullable: false, maxLength: 7),
                        BandId = c.Int(nullable: false),
                        UserId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.BandManagerId)
                .ForeignKey("dbo.Bands", t => t.BandId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId)
                .Index(t => t.BandManagerId, unique: true, name: "UniqueBandManagerId")
                .Index(t => t.BandId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Bands",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 70),
                        Image = c.String(),
                        OnboardDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                        UpdatedBy = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UpdatedBy)
                .Index(t => t.UpdatedBy);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 150),
                        DateOfBirth = c.DateTime(nullable: false),
                        BloodGroup = c.String(),
                        Password = c.String(nullable: false),
                        Image = c.String(),
                        UserType = c.Int(nullable: false),
                        Email = c.String(maxLength: 70),
                        PhoneNo = c.String(nullable: false, maxLength: 11),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 70),
                        IsActive = c.Boolean(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                        UpdatedBy = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UpdatedBy)
                .Index(t => t.UpdatedBy);
            
            CreateTable(
                "dbo.Colors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 70),
                        ColorCode = c.String(nullable: false, maxLength: 9),
                        IsActive = c.Boolean(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                        UpdatedBy = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UpdatedBy)
                .Index(t => t.UpdatedBy);
            
            CreateTable(
                "dbo.ProductColorMaps",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        ColorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Colors", t => t.ColorId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.ColorId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 150),
                        UpdatedBy = c.String(maxLength: 128),
                        UpdatedAt = c.DateTime(nullable: false),
                        Image = c.String(),
                        BuyingPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SellingPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        RevenuePercentage = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ProUnitId = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        BandId = c.Int(nullable: false),
                        GigId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Bands", t => t.BandId, cascadeDelete: true)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Gigs", t => t.GigId, cascadeDelete: true)
                .ForeignKey("dbo.ProductUnits", t => t.ProUnitId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UpdatedBy)
                .Index(t => t.UpdatedBy)
                .Index(t => t.ProUnitId)
                .Index(t => t.CategoryId)
                .Index(t => t.BandId)
                .Index(t => t.GigId);
            
            CreateTable(
                "dbo.Gigs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 170),
                        Image = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                        UpdatedBy = c.String(maxLength: 128),
                        LocationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Locations", t => t.LocationId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UpdatedBy)
                .Index(t => t.UpdatedBy)
                .Index(t => t.LocationId);
            
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 70),
                        IsActive = c.Boolean(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                        UpdatedBy = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UpdatedBy)
                .Index(t => t.UpdatedBy);
            
            CreateTable(
                "dbo.ProductOrderMaps",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        OrderId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.OrderId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        CustomerId = c.Int(nullable: false),
                        UpdatedBy = c.String(maxLength: 128),
                        UpdatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UpdatedBy)
                .Index(t => t.CustomerId)
                .Index(t => t.UpdatedBy);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 70),
                        Address = c.String(maxLength: 150),
                        PhoneNo = c.String(maxLength: 11),
                        Email = c.String(maxLength: 70),
                        IsActive = c.Boolean(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                        UpdatedBy = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UpdatedBy)
                .Index(t => t.PhoneNo, unique: true, name: "UniquePhoneNo")
                .Index(t => t.Email, unique: true, name: "UniqueEmail")
                .Index(t => t.UpdatedBy);
            
            CreateTable(
                "dbo.ProductSizeMaps",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        SizeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Sizes", t => t.SizeId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.SizeId);
            
            CreateTable(
                "dbo.Sizes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 70),
                        Measurement = c.String(nullable: false, maxLength: 50),
                        IsActive = c.Boolean(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                        UpdatedBy = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UpdatedBy)
                .Index(t => t.UpdatedBy);
            
            CreateTable(
                "dbo.ProductUnits",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 70),
                        IsActive = c.Boolean(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                        UpdatedBy = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UpdatedBy)
                .Index(t => t.UpdatedBy);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 70),
                        IsActive = c.Boolean(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                        UpdatedBy = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UpdatedBy)
                .Index(t => t.UpdatedBy);
            
            CreateTable(
                "dbo.Designations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 70),
                        IsActive = c.Boolean(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                        UpdatedBy = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UpdatedBy)
                .Index(t => t.UpdatedBy);
            
            CreateTable(
                "dbo.Divisions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 70),
                        IsActive = c.Boolean(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                        UpdatedBy = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UpdatedBy)
                .Index(t => t.UpdatedBy);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.String(nullable: false, maxLength: 7),
                        DateOfJoining = c.DateTime(nullable: false),
                        GradeId = c.Int(nullable: false),
                        DesignationId = c.Int(nullable: false),
                        UnitId = c.Int(nullable: false),
                        DepartmentId = c.Int(nullable: false),
                        DivisionId = c.Int(nullable: false),
                        LocationId = c.Int(nullable: false),
                        NidNo = c.String(nullable: false, maxLength: 17),
                        BrnNo = c.String(maxLength: 25),
                        PassportNo = c.String(maxLength: 25),
                        TinNo = c.String(maxLength: 35),
                        FathersName = c.String(nullable: false, maxLength: 150),
                        MothersName = c.String(nullable: false, maxLength: 150),
                        PresentAddress = c.String(nullable: false, maxLength: 250),
                        PermanentAddress = c.String(nullable: false, maxLength: 250),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.EmployeeId)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: true)
                .ForeignKey("dbo.Designations", t => t.DesignationId, cascadeDelete: true)
                .ForeignKey("dbo.Divisions", t => t.DivisionId, cascadeDelete: true)
                .ForeignKey("dbo.Grades", t => t.GradeId, cascadeDelete: true)
                .ForeignKey("dbo.Locations", t => t.LocationId, cascadeDelete: true)
                .ForeignKey("dbo.Units", t => t.UnitId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.EmployeeId, unique: true, name: "UniqueEmployeeId")
                .Index(t => t.GradeId)
                .Index(t => t.DesignationId)
                .Index(t => t.UnitId)
                .Index(t => t.DepartmentId)
                .Index(t => t.DivisionId)
                .Index(t => t.LocationId)
                .Index(t => t.NidNo, unique: true, name: "UniqueNidNo")
                .Index(t => t.BrnNo, unique: true, name: "UniqueBrnNo")
                .Index(t => t.PassportNo, unique: true, name: "UniquePassportNo")
                .Index(t => t.TinNo, unique: true, name: "UniqueTinNo")
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Grades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 70),
                        IsActive = c.Boolean(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                        UpdatedBy = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UpdatedBy)
                .Index(t => t.UpdatedBy);
            
            CreateTable(
                "dbo.Units",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 70),
                        IsActive = c.Boolean(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                        UpdatedBy = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UpdatedBy)
                .Index(t => t.UpdatedBy);
            
            CreateTable(
                "dbo.GigManagers",
                c => new
                    {
                        GigManagerId = c.String(nullable: false, maxLength: 7),
                        GigId = c.Int(nullable: false),
                        UserId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.GigManagerId)
                .ForeignKey("dbo.Gigs", t => t.GigId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId)
                .Index(t => t.GigManagerId, unique: true, name: "UniqueGigManagerId")
                .Index(t => t.GigId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Tokens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TokenKey = c.String(nullable: false, maxLength: 100),
                        UpdatedAt = c.DateTime(nullable: false),
                        ExpiredAt = c.DateTime(),
                        UserId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tokens", "UserId", "dbo.Users");
            DropForeignKey("dbo.GigManagers", "UserId", "dbo.Users");
            DropForeignKey("dbo.GigManagers", "GigId", "dbo.Gigs");
            DropForeignKey("dbo.Employees", "UserId", "dbo.Users");
            DropForeignKey("dbo.Employees", "UnitId", "dbo.Units");
            DropForeignKey("dbo.Units", "UpdatedBy", "dbo.Users");
            DropForeignKey("dbo.Employees", "LocationId", "dbo.Locations");
            DropForeignKey("dbo.Employees", "GradeId", "dbo.Grades");
            DropForeignKey("dbo.Grades", "UpdatedBy", "dbo.Users");
            DropForeignKey("dbo.Employees", "DivisionId", "dbo.Divisions");
            DropForeignKey("dbo.Employees", "DesignationId", "dbo.Designations");
            DropForeignKey("dbo.Employees", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.Divisions", "UpdatedBy", "dbo.Users");
            DropForeignKey("dbo.Designations", "UpdatedBy", "dbo.Users");
            DropForeignKey("dbo.Departments", "UpdatedBy", "dbo.Users");
            DropForeignKey("dbo.Colors", "UpdatedBy", "dbo.Users");
            DropForeignKey("dbo.ProductColorMaps", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Products", "UpdatedBy", "dbo.Users");
            DropForeignKey("dbo.Products", "ProUnitId", "dbo.ProductUnits");
            DropForeignKey("dbo.ProductUnits", "UpdatedBy", "dbo.Users");
            DropForeignKey("dbo.ProductSizeMaps", "SizeId", "dbo.Sizes");
            DropForeignKey("dbo.Sizes", "UpdatedBy", "dbo.Users");
            DropForeignKey("dbo.ProductSizeMaps", "ProductId", "dbo.Products");
            DropForeignKey("dbo.ProductOrderMaps", "ProductId", "dbo.Products");
            DropForeignKey("dbo.ProductOrderMaps", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.Orders", "UpdatedBy", "dbo.Users");
            DropForeignKey("dbo.Orders", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Customers", "UpdatedBy", "dbo.Users");
            DropForeignKey("dbo.Products", "GigId", "dbo.Gigs");
            DropForeignKey("dbo.Gigs", "UpdatedBy", "dbo.Users");
            DropForeignKey("dbo.Gigs", "LocationId", "dbo.Locations");
            DropForeignKey("dbo.Locations", "UpdatedBy", "dbo.Users");
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Products", "BandId", "dbo.Bands");
            DropForeignKey("dbo.ProductColorMaps", "ColorId", "dbo.Colors");
            DropForeignKey("dbo.Categories", "UpdatedBy", "dbo.Users");
            DropForeignKey("dbo.BandManagers", "UserId", "dbo.Users");
            DropForeignKey("dbo.BandManagers", "BandId", "dbo.Bands");
            DropForeignKey("dbo.Bands", "UpdatedBy", "dbo.Users");
            DropIndex("dbo.Tokens", new[] { "UserId" });
            DropIndex("dbo.GigManagers", new[] { "UserId" });
            DropIndex("dbo.GigManagers", new[] { "GigId" });
            DropIndex("dbo.GigManagers", "UniqueGigManagerId");
            DropIndex("dbo.Units", new[] { "UpdatedBy" });
            DropIndex("dbo.Grades", new[] { "UpdatedBy" });
            DropIndex("dbo.Employees", new[] { "UserId" });
            DropIndex("dbo.Employees", "UniqueTinNo");
            DropIndex("dbo.Employees", "UniquePassportNo");
            DropIndex("dbo.Employees", "UniqueBrnNo");
            DropIndex("dbo.Employees", "UniqueNidNo");
            DropIndex("dbo.Employees", new[] { "LocationId" });
            DropIndex("dbo.Employees", new[] { "DivisionId" });
            DropIndex("dbo.Employees", new[] { "DepartmentId" });
            DropIndex("dbo.Employees", new[] { "UnitId" });
            DropIndex("dbo.Employees", new[] { "DesignationId" });
            DropIndex("dbo.Employees", new[] { "GradeId" });
            DropIndex("dbo.Employees", "UniqueEmployeeId");
            DropIndex("dbo.Divisions", new[] { "UpdatedBy" });
            DropIndex("dbo.Designations", new[] { "UpdatedBy" });
            DropIndex("dbo.Departments", new[] { "UpdatedBy" });
            DropIndex("dbo.ProductUnits", new[] { "UpdatedBy" });
            DropIndex("dbo.Sizes", new[] { "UpdatedBy" });
            DropIndex("dbo.ProductSizeMaps", new[] { "SizeId" });
            DropIndex("dbo.ProductSizeMaps", new[] { "ProductId" });
            DropIndex("dbo.Customers", new[] { "UpdatedBy" });
            DropIndex("dbo.Customers", "UniqueEmail");
            DropIndex("dbo.Customers", "UniquePhoneNo");
            DropIndex("dbo.Orders", new[] { "UpdatedBy" });
            DropIndex("dbo.Orders", new[] { "CustomerId" });
            DropIndex("dbo.ProductOrderMaps", new[] { "OrderId" });
            DropIndex("dbo.ProductOrderMaps", new[] { "ProductId" });
            DropIndex("dbo.Locations", new[] { "UpdatedBy" });
            DropIndex("dbo.Gigs", new[] { "LocationId" });
            DropIndex("dbo.Gigs", new[] { "UpdatedBy" });
            DropIndex("dbo.Products", new[] { "GigId" });
            DropIndex("dbo.Products", new[] { "BandId" });
            DropIndex("dbo.Products", new[] { "CategoryId" });
            DropIndex("dbo.Products", new[] { "ProUnitId" });
            DropIndex("dbo.Products", new[] { "UpdatedBy" });
            DropIndex("dbo.ProductColorMaps", new[] { "ColorId" });
            DropIndex("dbo.ProductColorMaps", new[] { "ProductId" });
            DropIndex("dbo.Colors", new[] { "UpdatedBy" });
            DropIndex("dbo.Categories", new[] { "UpdatedBy" });
            DropIndex("dbo.Bands", new[] { "UpdatedBy" });
            DropIndex("dbo.BandManagers", new[] { "UserId" });
            DropIndex("dbo.BandManagers", new[] { "BandId" });
            DropIndex("dbo.BandManagers", "UniqueBandManagerId");
            DropTable("dbo.Tokens");
            DropTable("dbo.GigManagers");
            DropTable("dbo.Units");
            DropTable("dbo.Grades");
            DropTable("dbo.Employees");
            DropTable("dbo.Divisions");
            DropTable("dbo.Designations");
            DropTable("dbo.Departments");
            DropTable("dbo.ProductUnits");
            DropTable("dbo.Sizes");
            DropTable("dbo.ProductSizeMaps");
            DropTable("dbo.Customers");
            DropTable("dbo.Orders");
            DropTable("dbo.ProductOrderMaps");
            DropTable("dbo.Locations");
            DropTable("dbo.Gigs");
            DropTable("dbo.Products");
            DropTable("dbo.ProductColorMaps");
            DropTable("dbo.Colors");
            DropTable("dbo.Categories");
            DropTable("dbo.Users");
            DropTable("dbo.Bands");
            DropTable("dbo.BandManagers");
        }
    }
}
