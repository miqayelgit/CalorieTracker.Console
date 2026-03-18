

namespace CalorieTracker.Client.Entities
{
    public class DailyCalorieLimit
    {
        public Guid Id{ get; set; }
        public short DailyLimit{ get; set; }
        public short UsedLimit{ get; set; }
        public short RemainingLimit{ get; set; }
    }
}
