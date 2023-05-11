namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewMappingOrderAdded : DbMigration
    {
        public override void Up()
        {
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductOrderMaps", "ProductId", "dbo.Products");
            DropForeignKey("dbo.ProductOrderMaps", "OrderId", "dbo.Orders");
            DropIndex("dbo.ProductOrderMaps", new[] { "OrderId" });
            DropIndex("dbo.ProductOrderMaps", new[] { "ProductId" });
            DropTable("dbo.ProductOrderMaps");
        }
    }
}
