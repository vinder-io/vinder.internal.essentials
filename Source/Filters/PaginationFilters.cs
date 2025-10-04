namespace Vinder.Internal.Essentials.Filters;

public sealed record PaginationFilters
{
    public int PageNumber { get; set; } = 1;
    public int PageSize { get; set; } = 20;

    public int Skip => (PageNumber - 1) * PageSize;
    public int Take => PageSize;
}