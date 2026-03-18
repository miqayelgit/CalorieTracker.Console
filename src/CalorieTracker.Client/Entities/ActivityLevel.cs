namespace CalorieTracker.Client.Entities
{
    public class ActivityLevel
    {
        public Guid Id { get; set; }
        public string ActivityLevelName { get; set; } = null!;
        public float ActivityLevelRate { get; set; }
    }
}
