using CalorieTracker.Client;
using CalorieTracker.Client.Entities;
using CalorieTracker.Client.Interfaces;
using CalorieTracker.Client.Repositories.@base;
public class RoleRepository : RepositoryBase<Role>, IRoleRepository
{
    public RoleRepository(DatabaseContext context) : base(context)
    {
    }
}

