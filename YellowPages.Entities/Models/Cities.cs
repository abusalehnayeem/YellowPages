using System;

namespace YellowPages.Entities.Models
{
    public class Cities : BaseEntity
    {
        public string Name { get; set; }
        public string Image { get; set; }

        public Guid CountriesId { get; set; }
        public Countries Countries { get; set; }
    }
}