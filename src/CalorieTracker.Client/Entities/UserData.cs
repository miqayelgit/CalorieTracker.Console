namespace CalorieTracker.Client.Entities;

public class UserData
{
    public Guid Id { get; set; }
    public short Height { get; set; }
    public short Weight { get; set; }
    public byte Age { get; set; }
    public string ActivityLevel { get; set; } = null!;
    public string FitnessGoal { get; set; } = null!;

    public User User { get; set; } = null!;
}
