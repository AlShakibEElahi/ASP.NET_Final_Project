namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MappingTAbleAdded : DbMigration
    {
        public override void Up()
        {
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductColorMaps", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Products", "UpdatedBy", "dbo.Users");
            DropForeignKey("dbo.Products", "ProUnitId", "dbo.ProductUnits");
            DropForeignKey("dbo.ProductSizeMaps", "SizeId", "dbo.Sizes");
            DropForeignKey("dbo.ProductSizeMaps", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Products", "GigId", "dbo.Gigs");
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Products", "BandId", "dbo.Bands");
            DropForeignKey("dbo.ProductColorMaps", "ColorId", "dbo.Colors");
            DropIndex("dbo.ProductSizeMaps", new[] { "SizeId" });
            DropIndex("dbo.ProductSizeMaps", new[] { "ProductId" });
            DropIndex("dbo.Products", new[] { "GigId" });
            DropIndex("dbo.Products", new[] { "BandId" });
            DropIndex("dbo.Products", new[] { "CategoryId" });
            DropIndex("dbo.Products", new[] { "ProUnitId" });
            DropIndex("dbo.Products", new[] { "UpdatedBy" });
            DropIndex("dbo.ProductColorMaps", new[] { "ColorId" });
            DropIndex("dbo.ProductColorMaps", new[] { "ProductId" });
            DropTable("dbo.ProductSizeMaps");
            DropTable("dbo.Products");
            DropTable("dbo.ProductColorMaps");
        }
    }
}
