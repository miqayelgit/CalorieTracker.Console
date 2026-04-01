

using CalorieTracker.Client.Contracts.Interfaces;
using CalorieTracker.Client.Entities;
using CalorieTracker.Client.Repositories.@base;

namespace CalorieTracker.Client.Repositories;

public class FitnessGoalRepository : RepositoryBase<FitnessGoal>, IFitnessGoalRepository
{
    public FitnessGoalRepository(DatabaseContext context) : base(context)
    {
    }
}
