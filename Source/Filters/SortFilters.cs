namespace Vinder.Internal.Essentials.Filters;

public sealed record SortFilters
{
    public string Field { get; set; } = default!;
    public SortDirection Direction { get; set; }

    public static SortFilters From(string field, SortDirection direction = SortDirection.Ascending) => new()
    {
        Field = field,
        Direction = direction
    };
}
