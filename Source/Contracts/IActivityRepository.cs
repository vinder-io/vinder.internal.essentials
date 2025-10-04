namespace Vinder.Internal.Essentials.Contracts;

public interface IActivityRepository : IBaseRepository<Activity>
{
    public Task<IReadOnlyCollection<Activity>> GetActivitiesAsync(
        ActivityFilters filters,
        CancellationToken cancellation = default
    );

    public Task<long> CountAsync(
        ActivityFilters filters,
        CancellationToken cancellation = default
    );
}