using CalorieTracker.Client.Entities;

namespace CalorieTracker.Client.Contracts.Services;

public interface IFitnessGoalService
{
    public Task<IEnumerable<FitnessGoal>> GetFitnessGoalsAsync();
}