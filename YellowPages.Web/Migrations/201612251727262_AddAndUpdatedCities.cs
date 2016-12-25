namespace YellowPages.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAndUpdatedCities : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Image = c.String(),
                        CountriesId = c.Guid(nullable: false),
                        CreatDate = c.DateTime(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.CountriesId, cascadeDelete: true)
                .Index(t => t.CountriesId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cities", "CountriesId", "dbo.Countries");
            DropIndex("dbo.Cities", new[] { "CountriesId" });
            DropTable("dbo.Cities");
        }
    }
}
