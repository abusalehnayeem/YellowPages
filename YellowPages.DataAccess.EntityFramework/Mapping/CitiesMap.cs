using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YellowPages.Entities.Models;

namespace YellowPages.DataAccess.EntityFramework.Mapping
{
    public class CitiesMap:EntityTypeConfiguration<Cities>
    {
        public CitiesMap()
        {
            HasKey(ci => ci.Id);

            Property(ci => ci.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(ci => ci.Name).HasColumnName("Name").HasMaxLength(50).IsRequired().IsUnicode();
            Property(ci => ci.Image).HasColumnName("Image");
            Property(ci => ci.RowVersion).IsConcurrencyToken(true).IsRowVersion(); ;
            HasRequired(c => c.Countries).WithMany(ci => ci.Cities).HasForeignKey(ci => ci.CountriesId).WillCascadeOnDelete(false);

            ToTable("Cities");
        }
    }
}
