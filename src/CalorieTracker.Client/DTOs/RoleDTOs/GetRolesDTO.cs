using CalorieTracker.Client.Entities;
using CalorieTracker.Client.Enums;

namespace CalorieTracker.Client.DTOs.RoleDTOs
{
    public class GetRolesDTO
    {
        public RolesType RoleType { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
