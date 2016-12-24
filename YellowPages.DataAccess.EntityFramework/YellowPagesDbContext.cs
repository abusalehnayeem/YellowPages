using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YellowPages.DataAccess.EntityFramework.Mapping;
using YellowPages.Entities.Models;

namespace YellowPages.DataAccess.EntityFramework
{
    public class YellowPagesDbContext : DbContext
    {
        public YellowPagesDbContext() : base("Name=YellowDbConnection")
        {
            Database.SetInitializer<YellowPagesDbContext>(new CreateDatabaseIfNotExists<YellowPagesDbContext>());
        }

        public DbSet<Countries> Countries { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CountriesMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
