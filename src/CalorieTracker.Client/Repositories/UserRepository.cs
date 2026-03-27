

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

}
