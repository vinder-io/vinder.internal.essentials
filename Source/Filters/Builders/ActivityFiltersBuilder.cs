namespace Vinder.Internal.Essentials.Filters.Builders;

public sealed class ActivityFiltersBuilder :
    FiltersBuilderBase<ActivityFilters, ActivityFiltersBuilder>
{
    public ActivityFiltersBuilder WithAction(string? action)
    {
        _filters.Action = action;
        return this;
    }

    public ActivityFiltersBuilder WithUser(string? userId)
    {
        _filters.UserId = userId;
        return this;
    }

    public ActivityFiltersBuilder WithTenant(string? tenantId)
    {
        _filters.TenantId = tenantId;
        return this;
    }
}