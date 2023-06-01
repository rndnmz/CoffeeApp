namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CoffeeBeansTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                        WareHouseId = c.Int(nullable: false),
                        UnitPrice = c.Double(nullable: false),
                        Description = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderId = c.Int(nullable: false),
                        CoffeBeansTypeId = c.Int(nullable: false),
                        UnitPrice = c.Double(nullable: false),
                        Quantity = c.Double(nullable: false),
                        Discount = c.Double(nullable: false),
                        CoffeeBeansType_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CoffeeBeansTypes", t => t.CoffeeBeansType_Id)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.OrderId)
                .Index(t => t.CoffeeBeansType_Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        EmployeeId = c.Int(nullable: false),
                        OrderDate = c.DateTime(nullable: false),
                        ShipCity = c.String(maxLength: 20),
                        ShipRegion = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.CustomerId)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(nullable: false, maxLength: 20),
                        Authorized = c.String(maxLength: 40),
                        City = c.String(maxLength: 20),
                        Region = c.String(maxLength: 20),
                        Phone = c.String(maxLength: 15),
                        Email = c.String(maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                        Surname = c.String(nullable: false, maxLength: 20),
                        Duties = c.String(maxLength: 20),
                        UserName = c.String(nullable: false, maxLength: 20),
                        Password = c.String(nullable: false, maxLength: 20),
                        Activity = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.WareHouses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                        Authorized = c.String(nullable: false, maxLength: 20),
                        Phone = c.String(maxLength: 15),
                        Region = c.String(maxLength: 20),
                        City = c.String(maxLength: 20),
                        Adress = c.String(maxLength: 150),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.WareHouseCoffeeBeansTypes",
                c => new
                    {
                        WareHouse_Id = c.Int(nullable: false),
                        CoffeeBeansType_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.WareHouse_Id, t.CoffeeBeansType_Id })
                .ForeignKey("dbo.WareHouses", t => t.WareHouse_Id, cascadeDelete: true)
                .ForeignKey("dbo.CoffeeBeansTypes", t => t.CoffeeBeansType_Id, cascadeDelete: true)
                .Index(t => t.WareHouse_Id)
                .Index(t => t.CoffeeBeansType_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WareHouseCoffeeBeansTypes", "CoffeeBeansType_Id", "dbo.CoffeeBeansTypes");
            DropForeignKey("dbo.WareHouseCoffeeBeansTypes", "WareHouse_Id", "dbo.WareHouses");
            DropForeignKey("dbo.OrderDetails", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.Orders", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Orders", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.OrderDetails", "CoffeeBeansType_Id", "dbo.CoffeeBeansTypes");
            DropIndex("dbo.WareHouseCoffeeBeansTypes", new[] { "CoffeeBeansType_Id" });
            DropIndex("dbo.WareHouseCoffeeBeansTypes", new[] { "WareHouse_Id" });
            DropIndex("dbo.Orders", new[] { "EmployeeId" });
            DropIndex("dbo.Orders", new[] { "CustomerId" });
            DropIndex("dbo.OrderDetails", new[] { "CoffeeBeansType_Id" });
            DropIndex("dbo.OrderDetails", new[] { "OrderId" });
            DropTable("dbo.WareHouseCoffeeBeansTypes");
            DropTable("dbo.WareHouses");
            DropTable("dbo.Employees");
            DropTable("dbo.Customers");
            DropTable("dbo.Orders");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.CoffeeBeansTypes");
        }
    }
}
