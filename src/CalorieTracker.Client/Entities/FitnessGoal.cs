
namespace CalorieTracker.Client.Entities
{
    public class FitnessGoal
    {
        public Guid Id { get; set; }
        public string GoalName { get; set; } = null!;
        public byte ProteinPercent { get; set; }
        public byte FatPercent { get; set; }
        public byte CarbsPercent { get; set; }
        public ICollection<UserData> UserDatas { get; set; } = [];
    }
}
