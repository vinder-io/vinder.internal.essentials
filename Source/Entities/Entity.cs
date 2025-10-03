namespace Vinder.Internal.Essentials.Entities;

public abstract class Entity
{
    public string Id { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public bool IsDeleted { get; set; }

    public void MarkAsDeleted() => IsDeleted = true;
    public void MarkAsUpdated() => UpdatedAt = DateTime.UtcNow;
}