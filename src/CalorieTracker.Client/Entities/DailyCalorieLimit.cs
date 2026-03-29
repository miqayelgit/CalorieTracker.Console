

namespace CalorieTracker.Client.Entities;

public class DailyCalorieLimit
{
    public Guid Id{ get; set; }
    public Guid UserId { get; set; }
    public short DailyLimit{ get; set; }
    public short UsedLimit{ get; set; }
    public short RemainingLimit { get; set; }
    public DateTime CreatedDate { get; set; }
    public User User { get; set; } = null!;
}
