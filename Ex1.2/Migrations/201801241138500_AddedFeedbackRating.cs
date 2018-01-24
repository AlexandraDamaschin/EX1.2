namespace Ex1._2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedFeedbackRating : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Order", "FeedbackRating", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Order", "FeedbackRating");
        }
    }
}
