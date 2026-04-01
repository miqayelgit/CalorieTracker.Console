using CalorieTracker.Client.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTracker.Client.DTOs.UserDTOs
{
    public class UserAdvancedDataDTO
    {
        public Guid Id { get; set; }
        public string FitnessGoalName { get; set; } = null!;
        public string ActivityLevelName { get; set; } = null!;
        public List<DailyCalorieLimit> DailyCalorieLimits { get; set; } = null!;
        public List<DailyNutrientsIntakeAmount> DailyNutrientsIntakeAmounts { get; set; } = null!;
        public List<UserRole> UserRoles { get; set; } = null!;
        public short Height { get; set; }
        public short Weight { get; set; }
        public byte Age { get; set; }
    }
}
