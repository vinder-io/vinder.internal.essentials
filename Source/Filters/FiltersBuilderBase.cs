namespace Vinder.Internal.Essentials.Filters;

public abstract class FiltersBuilderBase<TFilters, TBuilder>
    where TFilters : Filters, new()
    where TBuilder : FiltersBuilderBase<TFilters, TBuilder>
{
    protected readonly TFilters _filters = new();

    public TBuilder WithIdentifier(string? identifier)
    {
        _filters.Id = identifier;
        return (TBuilder)this;
    }

    public TBuilder WithIsDeleted(bool? isDeleted)
    {
        _filters.IsDeleted = isDeleted;
        return (TBuilder)this;
    }

    public TBuilder WithPagination(int? pageNumber = null, int? pageSize = null)
    {
        if (pageNumber.HasValue || pageSize.HasValue)
        {
            _filters.Pagination = new PaginationFilters
            {
                PageNumber = pageNumber ?? 1,
                PageSize = pageSize ?? 20
            };
        }

        return (TBuilder)this;
    }

    public TBuilder WithSort(string? fieldName, SortDirection? direction = null)
    {
        if (!string.IsNullOrWhiteSpace(fieldName) && direction.HasValue)
        {
            _filters.Sort = SortFilters.From(fieldName, direction.Value);
        }

        return (TBuilder)this;
    }

    public TBuilder WithCreatedAfter(DateOnly? date)
    {
        _filters.CreatedAfter = date;
        return (TBuilder)this;
    }

    public TBuilder WithCreatedBefore(DateOnly? date)
    {
        _filters.CreatedBefore = date;
        return (TBuilder)this;
    }

    public TBuilder WithCreatedAt(DateOnly? date)
    {
        _filters.CreatedAt = date;
        return (TBuilder)this;
    }

    public TBuilder WithUpdatedAt(DateOnly? date)
    {
        _filters.UpdatedAt = date;
        return (TBuilder)this;
    }

    public TFilters Build() => _filters;
}
