

using CalorieTracker.Client.Entities;
using CalorieTracker.Client.Interfaces;
using CalorieTracker.Client.Repositories.@base;
using System.Security.Cryptography;
using System.Text;

namespace CalorieTracker.Client.Repositories;


public class UserRepository : RepositoryBase<User>, IUserRepository
{
    public UserRepository(DatabaseContext context) : base(context)
    {
    }

    public void RegisterUser(User user)
    {
         Add(user);
    }
    public async Task<IEnumerable<User>> GetAllUsers()
    {
        return await GetAll();
    }

    public async Task<User> GetUserByUsername(string username)
    {
        return await Get(x => x.UserName == username);
    }

}
