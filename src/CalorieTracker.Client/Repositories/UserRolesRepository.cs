
using CalorieTracker.Client.Entities;
using CalorieTracker.Client.Interfaces;
using CalorieTracker.Client.Repositories.@base;

namespace CalorieTracker.Client.Repositories;

public class UserRolesRepository : RepositoryBase<UserRole>, IUserRolesRepository
{
    public UserRolesRepository(DatabaseContext context) : base(context)
    {
    }
}
