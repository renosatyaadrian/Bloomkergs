using System.ComponentModel.DataAnnotations;

namespace Bloomkergs.Models
{
    public abstract class EntityBase<T>
    {
        [Key]
        public T Id { get; set; } = default!;
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    }
}