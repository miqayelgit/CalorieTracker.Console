

using CalorieTracker.Client.Contracts.Interfaces;
using CalorieTracker.Client.Entities;
using CalorieTracker.Client.Enums;
using CalorieTracker.Client.Repositories.@base;
using CalorieTracker.Client.UOW;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;

namespace CalorieTracker.Client.Repositories;


public class UserRepository : RepositoryBase<User>, IUserRepository
{
    public UserRepository(DatabaseContext context) : base(context)
    {
    }
    public async Task<IEnumerable<User>> GetUserAdvancedDataAsync()
    {
        return await _context.Users
            //.Where(x => x.UserData != null)
            .Include(x => x.UserData)
                .ThenInclude(x => x.FitnessGoal)
            .Include(x => x.UserData)
                .ThenInclude(x => x.ActivityLevel)
            .Include(x => x.UserRoles)
                .ThenInclude(x => x.Role)
            .Include(x => x.Products)
            .Include(x => x.DailyCalorieLimits)
            .Include(x => x.DailyNutrientsIntakeAmounts).ToListAsync();
    }

    public async Task<bool> IsAdminUserPresentAsync()
    {
        return await _context.Users
            .Where(x => x.UserRoles.Any(x => x.Role.RoleType == RolesType.Admin))
            .AnyAsync();
    }

    public async Task<bool> IsUserAlreadyCreatedAsync(string email)
    {
        return await _context.Users
            .Where(x => x.Email == email)
            .AnyAsync();
    }
}
