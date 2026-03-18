
namespace CalorieTracker.Client.Entities
{
    public class FitnessGoal
    {
        public Guid Id { get; set; }
        public string GoalName { get; set; } = null!;
        public float GoalValue { get; set; }
    }
}
