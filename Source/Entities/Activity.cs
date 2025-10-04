namespace Vinder.Internal.Essentials.Entities;

public sealed class Activity : Entity
{
    public string Action { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public Resource? Resource { get; set; } = default!;
    public Tenant? Tenant { get; set; } = default!;
    public User? User { get; set; } = default!;
    public Dictionary<string, string> Metadata { get; set; } = [];
}