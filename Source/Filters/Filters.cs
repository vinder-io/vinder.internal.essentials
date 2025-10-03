namespace Vinder.Internal.Essentials.Filters;

public abstract class Filters
{
    public string? Id { get; set; }
    public bool? IsDeleted { get; set; }

    public PaginationFilters? Pagination { get; set; }
    public SortFilters? Sort { get; set; }

    public DateOnly? CreatedAt { get; set; }
    public DateOnly? UpdatedAt { get; set; }

    public DateOnly? CreatedAfter { get; set; }
    public DateOnly? CreatedBefore { get; set; }
}
