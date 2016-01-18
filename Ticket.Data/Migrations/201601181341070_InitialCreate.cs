namespace Ticket.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Buses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.String(),
                        Capacity = c.Int(nullable: false),
                        Company_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.Company_Id)
                .Index(t => t.Company_Id);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Address = c.String(),
                        ContactPerson = c.String(nullable: false),
                        Fax = c.String(),
                        MobileBankingNumber = c.String(nullable: false),
                        MobileProvider = c.Int(nullable: false),
                        Name = c.String(),
                        Phone = c.String(nullable: false),
                        Tin = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Buses", "Company_Id", "dbo.Companies");
            DropIndex("dbo.Buses", new[] { "Company_Id" });
            DropTable("dbo.Companies");
            DropTable("dbo.Buses");
        }
    }
}
