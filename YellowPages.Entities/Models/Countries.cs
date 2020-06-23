using System.Collections.Generic;

namespace YellowPages.Entities.Models
{
    public class Countries : BaseEntity
    {
        public string Name { get; set; }
        public string FlagImage { get; set; }
        public virtual ICollection<Cities> Cities { get; set; }
    }
}