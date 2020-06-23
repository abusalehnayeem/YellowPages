using System;

namespace YellowPages.Entities.Models
{
    public class BaseEntity : IAuditableEntity
    {
        public Guid Id { get; set; }
        public byte[] RowVersion { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
    }
}