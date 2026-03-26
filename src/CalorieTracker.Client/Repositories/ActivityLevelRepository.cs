

using CalorieTracker.Client.Entities;
using CalorieTracker.Client.Interfaces;
using CalorieTracker.Client.Repositories.@base;

namespace CalorieTracker.Client.Repositories;

public class ActivityLevelRepository : RepositoryBase<ActivityLevel>, IActivityLevelRepository
{

    public ActivityLevelRepository(DatabaseContext context) : base(context)
    {
    }
    public void AddActivityLevel(ActivityLevel activityLevel)
    {
        Add(activityLevel);
        Commit();
    }

    public ActivityLevel GetActivityLevelByName(string name)
    {
        return Get(x => x.ActivityLevelName.Equals(name));
    }
}
