namespace Core.Persistence.Entities;
public abstract class Entity<TId>
{
    public TId Id { get; set; } = default(TId)!;
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    public DateTime? UpdatedTime { get; set; }
}