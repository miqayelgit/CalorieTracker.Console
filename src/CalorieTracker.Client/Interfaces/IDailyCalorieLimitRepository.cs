

using CalorieTracker.Client.Entities;

namespace CalorieTracker.Client.Interfaces;

internal interface IDailyCalorieLimitRepository
{
    public void AddLimits(DailyCalorieLimit limit);

    public DailyCalorieLimit GetDailyCalorieLimitByUserId(Guid userId);
}
