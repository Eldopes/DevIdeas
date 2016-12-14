namespace DevIdeas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ThreadProperties : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ideas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Text = c.String(),
                        CreationDate = c.DateTime(nullable: false),
                        Rating = c.Int(nullable: false),
                        Author_Id = c.String(maxLength: 128),
                        Game_Id = c.Int(),
                        Genre_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.Author_Id)
                .ForeignKey("dbo.Games", t => t.Game_Id)
                .ForeignKey("dbo.Genres", t => t.Genre_Id)
                .Index(t => t.Author_Id)
                .Index(t => t.Game_Id)
                .Index(t => t.Genre_Id);
            
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        NumberOfIdeas = c.Int(nullable: false),
                        Genre_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Genres", t => t.Genre_Id)
                .Index(t => t.Genre_Id);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        NumberOfIdeas = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ideas", "Genre_Id", "dbo.Genres");
            DropForeignKey("dbo.Ideas", "Game_Id", "dbo.Games");
            DropForeignKey("dbo.Games", "Genre_Id", "dbo.Genres");
            DropForeignKey("dbo.Ideas", "Author_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Games", new[] { "Genre_Id" });
            DropIndex("dbo.Ideas", new[] { "Genre_Id" });
            DropIndex("dbo.Ideas", new[] { "Game_Id" });
            DropIndex("dbo.Ideas", new[] { "Author_Id" });
            DropTable("dbo.Genres");
            DropTable("dbo.Games");
            DropTable("dbo.Ideas");
        }
    }
}
