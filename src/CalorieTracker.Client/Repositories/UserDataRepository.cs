

using CalorieTracker.Client.Entities;
using CalorieTracker.Client.Interfaces;
using CalorieTracker.Client.Repositories.@base;

namespace CalorieTracker.Client.Repositories;

public class UserDataRepository : RepositoryBase<UserData>, IUserDataRepository
{
    public UserDataRepository(DatabaseContext context) : base(context)
    {
    }
}
