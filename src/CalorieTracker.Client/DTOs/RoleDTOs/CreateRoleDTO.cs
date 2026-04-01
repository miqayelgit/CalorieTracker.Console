
using CalorieTracker.Client.Entities;
using CalorieTracker.Client.Enums;

namespace CalorieTracker.Client.DTOs.RoleDTOs;

public class CreateRoleDTO
{
    public required RolesType RoleType { get; set; }

}
