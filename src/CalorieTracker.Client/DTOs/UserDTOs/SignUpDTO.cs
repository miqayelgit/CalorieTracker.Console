using CalorieTracker.Client.Entities;
using CalorieTracker.Client.Enums;

namespace CalorieTracker.Client.DTOs.UserDTOs;

public class SignUpDTO
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string UserName { get; set; }
    public required string Email { get; set; }
    public required string Password { get; set; }
    public required RolesType RoleType { get; set; }
}
