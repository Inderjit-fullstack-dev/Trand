using System.ComponentModel.DataAnnotations;

namespace Catalog.API.Domain.Entities
{
    public class BaseEntity
    {
        [Key]
        public long Id { get; set; }

        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
