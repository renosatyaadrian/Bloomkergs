namespace Bloomkergs.Models
{
    public abstract class EntityBase<T>
    {
        public T Id { get; set; } = default!;
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    }
}