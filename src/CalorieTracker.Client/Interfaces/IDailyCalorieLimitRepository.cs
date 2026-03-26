

using CalorieTracker.Client.Entities;

namespace CalorieTracker.Client.Interfaces;

public interface IDailyCalorieLimitRepository: IRepositoryBase <DailyCalorieLimit>
{
    public void AddLimits(DailyCalorieLimit limit);

    public Task<DailyCalorieLimit> GetDailyCalorieLimitByUserId(Guid userId);
}
