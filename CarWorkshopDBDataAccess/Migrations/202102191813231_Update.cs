namespace CarWorkshopDBDataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ClientRefID = c.Int(nullable: false),
                        Brand = c.String(nullable: false, maxLength: 30),
                        Model = c.String(nullable: false, maxLength: 30),
                        VIN = c.String(nullable: false, maxLength: 15),
                        RegistrationNumber = c.String(nullable: false, maxLength: 8),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Clients", t => t.ClientRefID, cascadeDelete: true)
                .Index(t => t.ClientRefID);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Surname = c.String(nullable: false, maxLength: 50),
                        Name = c.String(nullable: false, maxLength: 50),
                        PhoneNumber = c.String(nullable: false, maxLength: 15),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Mechanics",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Surname = c.String(nullable: false, maxLength: 50),
                        Name = c.String(nullable: false, maxLength: 50),
                        PhoneNumber = c.String(nullable: false, maxLength: 15),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Repairs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CarRefID = c.Int(nullable: false),
                        RepairPrize = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BringingDate = c.DateTime(),
                        CollectDate = c.DateTime(),
                        RepairDescription = c.String(maxLength: 200),
                        MechanicRefID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Cars", t => t.CarRefID, cascadeDelete: true)
                .ForeignKey("dbo.Mechanics", t => t.MechanicRefID, cascadeDelete: true)
                .Index(t => t.CarRefID)
                .Index(t => t.MechanicRefID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Repairs", "MechanicRefID", "dbo.Mechanics");
            DropForeignKey("dbo.Repairs", "CarRefID", "dbo.Cars");
            DropForeignKey("dbo.Cars", "ClientRefID", "dbo.Clients");
            DropIndex("dbo.Repairs", new[] { "MechanicRefID" });
            DropIndex("dbo.Repairs", new[] { "CarRefID" });
            DropIndex("dbo.Cars", new[] { "ClientRefID" });
            DropTable("dbo.Repairs");
            DropTable("dbo.Mechanics");
            DropTable("dbo.Clients");
            DropTable("dbo.Cars");
        }
    }
}
