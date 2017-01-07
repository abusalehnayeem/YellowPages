namespace YellowPages.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateTablesDefination : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cities", "CreatDateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Cities", "ModifiedDateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Countries", "CreatDateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Countries", "ModifiedDateTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.Cities", "CreatDate");
            DropColumn("dbo.Countries", "CreatDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Countries", "CreatDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Cities", "CreatDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Countries", "ModifiedDateTime");
            DropColumn("dbo.Countries", "CreatDateTime");
            DropColumn("dbo.Cities", "ModifiedDateTime");
            DropColumn("dbo.Cities", "CreatDateTime");
        }
    }
}
