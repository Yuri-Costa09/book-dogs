namespace BookDog.Domain.Shared
{
    public abstract class BaseEntity // abstract entity for generating IDs and timestamps for entities.
    {
        public Guid Id { get; protected set; } = Guid.NewGuid();
        public DateTime CreatedAt { get; protected set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; protected set; } = DateTime.Now;
    }
}