namespace Vinder.Internal.Essentials.Filters;

public sealed class ActivityFilters : Filters
{
    public string? Action { get; set; }
    public string? UserId { get; set; }
    public string? TenantId { get; set; }
}