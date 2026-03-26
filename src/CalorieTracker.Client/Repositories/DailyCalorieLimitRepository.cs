

using CalorieTracker.Client.Configurations;
using CalorieTracker.Client.Entities;
using CalorieTracker.Client.Interfaces;
using CalorieTracker.Client.Repositories.@base;

namespace CalorieTracker.Client.Repositories;

public class DailyCalorieLimitRepository : RepositoryBase<DailyCalorieLimit>, IDailyCalorieLimitRepository
{
    public DailyCalorieLimitRepository(DatabaseContext context) : base(context)
    {   
    }

    public void AddLimits(DailyCalorieLimit limit )
    {
        Add(limit);
        Commit();
    }

    public DailyCalorieLimit GetDailyCalorieLimitByUserId(Guid userId)
    {
        return Get(x => x.Id.Equals(userId));
    }
}
