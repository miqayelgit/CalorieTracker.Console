

using CalorieTracker.Client.Entities;
using CalorieTracker.Client.Interfaces;
using CalorieTracker.Client.Repositories.@base;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;

namespace CalorieTracker.Client.Repositories;


public class UserRepository : RepositoryBase<User>, IUserRepository
{
    public UserRepository(DatabaseContext context) : base(context)
    {
    }

    public async Task<IEnumerable<User>> GetAllUsers()
    {
        return await GetAllAsync();
    }

    public async Task<User> GetUserByUsername(string username)
    {
        return await GetAsync(x => x.UserName == username);
    }

}
