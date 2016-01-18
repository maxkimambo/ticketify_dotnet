namespace Ticket.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            this.CreateTable(
                "dbo.Buses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.String(),
                        Capacity = c.Int(),
                        Company_Id = c.Int(nullable:false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.Company_Id)
                .Index(t => t.Company_Id);

            this.CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Address = c.String(),
                        ContactPerson = c.String(),
                        Fax = c.String(),
                        MobileBankingNumber = c.String(),
                        MobileProvider = c.Int(),
                        Name = c.String(),
                        Phone = c.String(),
                        Tin = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            this.DropForeignKey("dbo.Buses", "Company_Id", "dbo.Companies");
            this.DropIndex("dbo.Buses", new[] { "Company_Id" });
            this.DropTable("dbo.Companies");
            this.DropTable("dbo.Buses");
        }
    }
}
