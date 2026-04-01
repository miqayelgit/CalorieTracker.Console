using CalorieTracker.Client.Entities;

namespace CalorieTracker.Client.Contracts.Services;

public interface IActivityLevelService
{
    public Task<IEnumerable<ActivityLevel>> GetActivityLevels();
}