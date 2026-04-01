

using CalorieTracker.Client.Contracts.Services;
using CalorieTracker.Client.Entities;
using CalorieTracker.Client.UOW;

namespace CalorieTracker.Client.Services;

internal class FitnessGoalService : IFitnessGoalService
{
    private readonly UnitOfWork _unitOfWork;

    public FitnessGoalService(UnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<FitnessGoal>> GetFitnessGoalsAsync()
    {
        return await _unitOfWork.FitnessGoalRepository.GetAllAsync();
    }
}
