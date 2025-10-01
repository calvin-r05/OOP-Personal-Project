namespace Project1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Actors",
                c => new
                    {
                        ActorID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        MovieID = c.Int(nullable: false),
                        Role = c.String(),
                    })
                .PrimaryKey(t => t.ActorID)
                .ForeignKey("dbo.Movies", t => t.MovieID, cascadeDelete: true)
                .Index(t => t.MovieID);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        MovieID = c.Int(nullable: false, identity: true),
                        MovieName = c.String(),
                        Director = c.String(),
                        YearReleased = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MovieID);
            
            CreateTable(
                "dbo.Favorites",
                c => new
                    {
                        FavoriteID = c.Int(nullable: false, identity: true),
                        Movie = c.String(),
                    })
                .PrimaryKey(t => t.FavoriteID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Actors", "MovieID", "dbo.Movies");
            DropIndex("dbo.Actors", new[] { "MovieID" });
            DropTable("dbo.Favorites");
            DropTable("dbo.Movies");
            DropTable("dbo.Actors");
        }
    }
}
