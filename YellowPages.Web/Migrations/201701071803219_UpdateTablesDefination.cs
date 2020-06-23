using System.Data.Entity.Migrations;

namespace YellowPages.Web.Migrations
{
    public partial class UpdateTablesDefination : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cities", "CreatDateTime", c => c.DateTime(false));
            AddColumn("dbo.Cities", "ModifiedDateTime", c => c.DateTime(false));
            AddColumn("dbo.Countries", "CreatDateTime", c => c.DateTime(false));
            AddColumn("dbo.Countries", "ModifiedDateTime", c => c.DateTime(false));
            DropColumn("dbo.Cities", "CreatDate");
            DropColumn("dbo.Countries", "CreatDate");
        }

        public override void Down()
        {
            AddColumn("dbo.Countries", "CreatDate", c => c.DateTime(false));
            AddColumn("dbo.Cities", "CreatDate", c => c.DateTime(false));
            DropColumn("dbo.Countries", "ModifiedDateTime");
            DropColumn("dbo.Countries", "CreatDateTime");
            DropColumn("dbo.Cities", "ModifiedDateTime");
            DropColumn("dbo.Cities", "CreatDateTime");
        }
    }
}