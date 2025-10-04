namespace Vinder.Internal.Essentials.Filters.Builders;

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

    public TBuilder WithPagination(PaginationFilters? pagination)
    {
        if (pagination is not null)
        {
            _filters.Pagination = pagination;
        }

        return (TBuilder)this;
    }

    public TBuilder WithSort(SortFilters? sort)
    {
        if (sort is not null)
        {
            _filters.Sort = sort;
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
