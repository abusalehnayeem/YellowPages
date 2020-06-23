using System.Data.Entity.Migrations;

namespace YellowPages.Web.Migrations
{
    public partial class UpdateAllTablesDefination : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cities", "CreatedDate", c => c.DateTime());
            AddColumn("dbo.Cities", "CreatedBy", c => c.String());
            AddColumn("dbo.Cities", "LastModifiedDate", c => c.DateTime());
            AddColumn("dbo.Cities", "LastModifiedBy", c => c.String());
            AddColumn("dbo.Countries", "CreatedDate", c => c.DateTime());
            AddColumn("dbo.Countries", "CreatedBy", c => c.String());
            AddColumn("dbo.Countries", "LastModifiedDate", c => c.DateTime());
            AddColumn("dbo.Countries", "LastModifiedBy", c => c.String());
            DropColumn("dbo.Cities", "CreatDateTime");
            DropColumn("dbo.Cities", "ModifiedDateTime");
            DropColumn("dbo.Countries", "CreatDateTime");
            DropColumn("dbo.Countries", "ModifiedDateTime");
        }

        public override void Down()
        {
            AddColumn("dbo.Countries", "ModifiedDateTime", c => c.DateTime(false));
            AddColumn("dbo.Countries", "CreatDateTime", c => c.DateTime(false));
            AddColumn("dbo.Cities", "ModifiedDateTime", c => c.DateTime(false));
            AddColumn("dbo.Cities", "CreatDateTime", c => c.DateTime(false));
            DropColumn("dbo.Countries", "LastModifiedBy");
            DropColumn("dbo.Countries", "LastModifiedDate");
            DropColumn("dbo.Countries", "CreatedBy");
            DropColumn("dbo.Countries", "CreatedDate");
            DropColumn("dbo.Cities", "LastModifiedBy");
            DropColumn("dbo.Cities", "LastModifiedDate");
            DropColumn("dbo.Cities", "CreatedBy");
            DropColumn("dbo.Cities", "CreatedDate");
        }
    }
}