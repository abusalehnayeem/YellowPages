namespace YellowPages.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAndUpdatedCitiesCascadeDelete : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Cities", "CountriesId", "dbo.Countries");
            AddForeignKey("dbo.Cities", "CountriesId", "dbo.Countries", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cities", "CountriesId", "dbo.Countries");
            AddForeignKey("dbo.Cities", "CountriesId", "dbo.Countries", "Id", cascadeDelete: true);
        }
    }
}
