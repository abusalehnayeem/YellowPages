using System.Data.Entity.Migrations;

namespace YellowPages.Web.Migrations
{
    public partial class AddAndUpdatedCities : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                    "dbo.Cities",
                    c => new
                    {
                        Id = c.Guid(false, true),
                        Name = c.String(false, 50),
                        Image = c.String(),
                        CountriesId = c.Guid(false),
                        CreatDate = c.DateTime(false),
                        RowVersion = c.Binary(false, fixedLength: true, timestamp: true, storeType: "rowversion")
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.CountriesId, true)
                .Index(t => t.CountriesId);
        }

        public override void Down()
        {
            DropForeignKey("dbo.Cities", "CountriesId", "dbo.Countries");
            DropIndex("dbo.Cities", new[] {"CountriesId"});
            DropTable("dbo.Cities");
        }
    }
}