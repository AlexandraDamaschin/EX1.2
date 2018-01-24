namespace Ex1._2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedEmailField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.User", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.User", "Email");
        }
    }
}
