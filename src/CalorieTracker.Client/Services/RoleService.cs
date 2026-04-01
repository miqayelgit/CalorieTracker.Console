
using CalorieTracker.Client.Contracts.Services;
using CalorieTracker.Client.DTOs.RoleDTOs;
using CalorieTracker.Client.Entities;
using CalorieTracker.Client.UOW;
using Microsoft.EntityFrameworkCore;

namespace CalorieTracker.Client.Services;

public class RoleService : IRoleService
{
    private readonly UnitOfWork _unitOfWork;

    public RoleService(UnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task CreateRole(CreateRoleDTO createRoleDTO)
    {

        Role role = new()
        {
            RoleType = createRoleDTO.RoleType,
        };

        _unitOfWork.RoleRepository.Create(role);
        await _unitOfWork.CommitAsync();  
    }

    public async Task<List<GetRolesDTO>> GetRolesAsync()
    {
        IEnumerable<Role> roles = await _unitOfWork.RoleRepository.GetAllAsync();

        return roles.Select(x => new GetRolesDTO { RoleType = x.RoleType, CreatedDate = x.CreatedDate }).ToList();
    }
}
