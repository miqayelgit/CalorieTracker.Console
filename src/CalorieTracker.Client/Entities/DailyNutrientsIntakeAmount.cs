

namespace CalorieTracker.Client.Entities
{
    public  class DailyNutrientsIntakeAmount
    {
        public Guid Id { get; set; }

        public short Protein{ get; set; }
        public short Fat{ get; set; }
        public short Carbs{ get; set; }

        public User User { get; set; } = null!;
    }
}
