namespace Project1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Images : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Actors", "Images", c => c.String());
            AddColumn("dbo.Movies", "Images", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "Images");
            DropColumn("dbo.Actors", "Images");
        }
    }
}
