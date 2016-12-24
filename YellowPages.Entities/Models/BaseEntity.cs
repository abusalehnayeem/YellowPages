using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YellowPages.Entities.Models
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatDate { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
