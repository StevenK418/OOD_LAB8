namespace GamesCharacters.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Characters",
                c => new
                    {
                        CharacterID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Species = c.String(),
                        Color = c.String(),
                        ComputerGameID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CharacterID)
                .ForeignKey("dbo.ComputerGames", t => t.ComputerGameID, cascadeDelete: true)
                .Index(t => t.ComputerGameID);
            
            CreateTable(
                "dbo.ComputerGames",
                c => new
                    {
                        ComputerGameID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Publisher = c.String(),
                        Description = c.String(),
                        ESRBRating = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ComputerGameID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Characters", "ComputerGameID", "dbo.ComputerGames");
            DropIndex("dbo.Characters", new[] { "ComputerGameID" });
            DropTable("dbo.ComputerGames");
            DropTable("dbo.Characters");
        }
    }
}
