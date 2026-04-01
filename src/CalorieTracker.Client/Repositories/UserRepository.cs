

using CalorieTracker.Client.Contracts.Interfaces;
using CalorieTracker.Client.Entities;
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
        return await _context.Set<User>()     
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
}
