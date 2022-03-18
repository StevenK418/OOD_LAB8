namespace GamesCharacters.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCharacterImagePath : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Characters", "Image", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Characters", "Image");
        }
    }
}
