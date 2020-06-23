using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using YellowPages.Entities.Models;

namespace YellowPages.DataAccess.EntityFramework.Mapping
{
    public class CountriesMap : EntityTypeConfiguration<Countries>
    {
        public CountriesMap()
        {
            HasKey(c => c.Id);

            Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Name).HasColumnName("Name").HasMaxLength(50).IsRequired().IsUnicode();
            Property(c => c.FlagImage).HasColumnName("FlagImage");
            Property(c => c.RowVersion).IsConcurrencyToken(true).IsRowVersion();

            ToTable("Countries");
        }
    }
}