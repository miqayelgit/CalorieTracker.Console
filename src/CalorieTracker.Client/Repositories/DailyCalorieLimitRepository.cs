

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
    }

    public async Task<DailyCalorieLimit> GetDailyCalorieLimitByUserId(Guid userId)
    {
        return await Get(x => x.Id == userId);
    }
}
