using CalorieTracker.Client;
using CalorieTracker.Client.Contracts.Interfaces;
using CalorieTracker.Client.Entities;
using CalorieTracker.Client.Repositories.@base;
using CalorieTracker.Client.UOW;
using Microsoft.EntityFrameworkCore;
public class RoleRepository : RepositoryBase<Role>, IRoleRepository
{
    public RoleRepository(DatabaseContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Role>> GetRolesAdvancedData()
    {
        return await _context.Roles            
            .Include(x => x.UserRoles)
                .ThenInclude(x => x.User)
            .ToListAsync();
    }
}

