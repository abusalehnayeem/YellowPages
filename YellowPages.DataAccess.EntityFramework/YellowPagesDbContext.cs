using System;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using YellowPages.DataAccess.EntityFramework.Mapping;
using YellowPages.Entities.Models;

namespace YellowPages.DataAccess.EntityFramework
{
    public class YellowPagesDbContext : DbContext
    {
        public YellowPagesDbContext() : base("Name=YellowDbConnection")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<YellowPagesDbContext>());
        }
        internal YellowPagesDbContext(string connectionString) : base(connectionString)
        {

        }

        public YellowPagesDbContext(HttpContext context)
        {
            _context = context;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CountriesMap());
            modelBuilder.Configurations.Add(new CitiesMap());
            base.OnModelCreating(modelBuilder);
        }

        public override async Task<int> SaveChangesAsync()
        {
            var currentDateTime = DateTime.Now;

            foreach (
                var auditableEntity in
                ChangeTracker.Entries<IAuditableEntity>()
                    .Where(
                        auditableEntity =>
                            auditableEntity.State == EntityState.Added ||
                            auditableEntity.State == EntityState.Modified))
            {
                auditableEntity.Entity.LastModifiedDate = currentDateTime;
                switch (auditableEntity.State)
                {
                    case EntityState.Added:
                        auditableEntity.Entity.CreatedDate = currentDateTime;
                        auditableEntity.Entity.CreatedBy = _context.User.Identity.Name;
                        break;
                    case EntityState.Modified:
                        auditableEntity.Entity.LastModifiedDate = currentDateTime;
                        auditableEntity.Entity.LastModifiedBy = _context.User.Identity.Name;
                        if (auditableEntity.Property(p => p.CreatedDate).IsModified ||
                            auditableEntity.Property(p => p.CreatedBy).IsModified)
                            throw new DbEntityValidationException(
                                string.Format("Attempt to change created audit trails on a modified {0}",
                                    auditableEntity.Entity.GetType().FullName));
                        break;
                    case EntityState.Detached:
                        break;
                    case EntityState.Unchanged:
                        break;
                    case EntityState.Deleted:
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }

            return await base.SaveChangesAsync();
        }

        #region Variable

        private readonly HttpContext _context;
        public DbSet<Countries> Countries { get; set; }
        public DbSet<Cities> Cities { get; set; }

        #endregion
    }
}