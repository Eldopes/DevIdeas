namespace DevIdeas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NumberOfIdeas1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "NumberOfIDeas", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "NumberOfIDeas");
        }
    }
}
