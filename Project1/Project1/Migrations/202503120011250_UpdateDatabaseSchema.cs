namespace Project1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDatabaseSchema : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Favorites", "Movie_MovieID", c => c.Int());
            CreateIndex("dbo.Favorites", "Movie_MovieID");
            AddForeignKey("dbo.Favorites", "Movie_MovieID", "dbo.Movies", "MovieID");
            DropColumn("dbo.Favorites", "Movie");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Favorites", "Movie", c => c.String());
            DropForeignKey("dbo.Favorites", "Movie_MovieID", "dbo.Movies");
            DropIndex("dbo.Favorites", new[] { "Movie_MovieID" });
            DropColumn("dbo.Favorites", "Movie_MovieID");
        }
    }
}
