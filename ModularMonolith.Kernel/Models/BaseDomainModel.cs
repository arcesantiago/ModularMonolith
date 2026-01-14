namespace ModularMonolith.Kernel.Models
{
    public abstract class BaseDomainModel
    {
        public int Id { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}
