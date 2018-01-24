namespace Ex1._2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedOrderTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Order",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DeliveredOn = c.DateTime(nullable: false),
                        OrderOn = c.DateTime(nullable: false),
                        Value = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Order");
        }
    }
}
