namespace Vinder.Internal.Essentials.Filters;

public sealed class SortFilters
{
    public string Field { get; set; }
    public SortDirection Direction { get; set; }

    private SortFilters(string field, SortDirection direction)
    {
        Field = field;
        Direction = direction;
    }

    public static SortFilters From(string field, SortDirection direction = SortDirection.Ascending)
        => new(field, direction);
}
