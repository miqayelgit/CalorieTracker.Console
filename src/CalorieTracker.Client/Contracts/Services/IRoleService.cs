using CalorieTracker.Client.DTOs.RoleDTOs;
using CalorieTracker.Client.Entities;

namespace CalorieTracker.Client.Contracts.Services;

public interface IRoleService
{
    public Task CreateRole(CreateRoleDTO createRoleDTO);
    public Task<List<GetRolesDTO>> GetRolesAsync();

}
