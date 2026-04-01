using CalorieTracker.Client.Enums;

namespace CalorieTracker.Client.Entities
{
    public class Role
    {
        public Guid Id { get; set; }
        public RolesType RoleType { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public ICollection<UserRole> UserRoles { get; set; } = [];
    }
}
