using System;

namespace YellowPages.Entities.Models
{
    public interface IAuditableEntity
    {
        DateTime? CreatedDate { get; set; }
        string CreatedBy { get; set; }
        DateTime? LastModifiedDate { get; set; }
        string LastModifiedBy { get; set; }
    }
}