namespace SipraişUygulaması.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sv1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        InvoiceId = c.Int(nullable: false, identity: true),
                        OrderId = c.Int(nullable: false),
                        AddedTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.InvoiceId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        ShopId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        ProductName = c.String(),
                        Quantity = c.Int(nullable: false),
                        Amount = c.Double(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Time = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.OrderId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Category = c.String(nullable: false),
                        ShopId = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId);
            
            CreateTable(
                "dbo.ShopAccouts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ShopId = c.Int(nullable: false),
                        UserName = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Shops",
                c => new
                    {
                        ShopId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        City = c.String(nullable: false),
                        Tel = c.Long(nullable: false),
                        CloseTime = c.DateTime(nullable: false),
                        IsSentry = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ShopId);
            
            CreateTable(
                "dbo.UserAccounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        UserName = c.String(nullable: false),
                        Password = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Surname = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        Tel = c.Long(nullable: false),
                        City = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.UserAccounts");
            DropTable("dbo.Shops");
            DropTable("dbo.ShopAccouts");
            DropTable("dbo.Products");
            DropTable("dbo.Orders");
            DropTable("dbo.Invoices");
        }
    }
}
