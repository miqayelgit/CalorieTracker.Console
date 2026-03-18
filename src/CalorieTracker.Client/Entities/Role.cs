namespace CalorieTracker.Client.Entities
{
    public class Role
    {
        public Guid Id { get; set; }
        public string RoleName { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
    }
}
