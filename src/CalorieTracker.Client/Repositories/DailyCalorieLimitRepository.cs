

using CalorieTracker.Client.Configurations;
using CalorieTracker.Client.Contracts.Interfaces;
using CalorieTracker.Client.Entities;
using CalorieTracker.Client.Repositories.@base;

namespace CalorieTracker.Client.Repositories;

public class DailyCalorieLimitRepository : RepositoryBase<DailyCalorieLimit>, IDailyCalorieLimitRepository
{
    public DailyCalorieLimitRepository(DatabaseContext context) : base(context)
    {   
    }
}
