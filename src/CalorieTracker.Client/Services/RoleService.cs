
using CalorieTracker.Client.DTOs.RoleDTOs;
using CalorieTracker.Client.Entities;
using CalorieTracker.Client.UOW;
using Microsoft.EntityFrameworkCore;

namespace CalorieTracker.Client.Services;

public class RoleService
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

    public async Task<IEnumerable<Role>> GetRolesAsync()
    {
        return await _unitOfWork.RoleRepository.GetAllAsync();
    }
    public async Task<IEnumerable<Role>> GetRolesAllData()
    {
        return await _unitOfWork.RoleRepository.GetAllData()
            .Include(x => x.UserRoles)
                .ThenInclude(x => x.User)
            .ToListAsync();
    }

}
