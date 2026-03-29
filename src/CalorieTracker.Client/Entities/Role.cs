using CalorieTracker.Client.Enums;

namespace CalorieTracker.Client.Entities
{
    public class Role
    {
        public Guid Id { get; set; }
        public RolesTypes RoleType { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public ICollection<UserRole> UserRoles { get; set; } = [];
    }
}
