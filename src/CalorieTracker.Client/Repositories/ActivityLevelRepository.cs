

using CalorieTracker.Client.Contracts.Interfaces;
using CalorieTracker.Client.Entities;
using CalorieTracker.Client.Repositories.@base;

namespace CalorieTracker.Client.Repositories;

public class ActivityLevelRepository : RepositoryBase<ActivityLevel>, IActivityLevelRepository
{

    public ActivityLevelRepository(DatabaseContext context) : base(context)
    {
    }
 
}
