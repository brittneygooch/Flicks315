namespace Flicks315.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MovieIntialSetup : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Actors",
                c => new
                    {
                        ActorId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Awards = c.Int(nullable: false),
                        MovieId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ActorId)
                .ForeignKey("dbo.Movies", t => t.MovieId, cascadeDelete: true)
                .Index(t => t.MovieId);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        MovieId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Rating = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.MovieId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Actors", "MovieId", "dbo.Movies");
            DropIndex("dbo.Actors", new[] { "MovieId" });
            DropTable("dbo.Movies");
            DropTable("dbo.Actors");
        }
    }
}
