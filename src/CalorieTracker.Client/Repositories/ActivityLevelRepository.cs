

using CalorieTracker.Client.Entities;
using CalorieTracker.Client.Interfaces;
using CalorieTracker.Client.Repositories.@base;

namespace CalorieTracker.Client.Repositories;

public class ActivityLevelRepository : RepositoryBase<ActivityLevel>
{

    public ActivityLevelRepository(DatabaseContext context) : base(context)
    {
    }
  
    public async Task<IEnumerable<ActivityLevel>> GetActivityLevels()
    {
        return await GetAll();
    }
}
