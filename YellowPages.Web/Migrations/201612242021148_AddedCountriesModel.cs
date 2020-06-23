using System.Data.Entity.Migrations;

namespace YellowPages.Web.Migrations
{
    public partial class AddedCountriesModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                    "dbo.Countries",
                    c => new
                    {
                        Id = c.Guid(false, true),
                        Name = c.String(false, 50),
                        FlagImage = c.String(),
                        CreatDate = c.DateTime(false),
                        RowVersion = c.Binary(false, fixedLength: true, timestamp: true, storeType: "rowversion")
                    })
                .PrimaryKey(t => t.Id);
        }

        public override void Down()
        {
            DropTable("dbo.Countries");
        }
    }
}