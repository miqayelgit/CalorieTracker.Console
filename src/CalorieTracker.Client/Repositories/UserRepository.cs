

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
        Commit();
    }
    public IEnumerable<User> GetAllUsers()
    {
        return GetAll();
    }

    public User GetUserByUsername(string username)
    {
        return Get(x => x.UserName.Equals(username));
    }

}
