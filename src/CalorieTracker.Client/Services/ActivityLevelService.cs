
using CalorieTracker.Client.Contracts.Services;
using CalorieTracker.Client.Entities;
using CalorieTracker.Client.UOW;

namespace CalorieTracker.Client.Services;

public class ActivityLevelService : IActivityLevelService
{
    private readonly UnitOfWork _unitOfWork;

    public ActivityLevelService(UnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<ActivityLevel>> GetActivityLevels()
    {
        return await _unitOfWork.ActivityLevelRepository.GetAllAsync();
    }
}
