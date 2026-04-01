using CalorieTracker.Client.Contracts.Interfaces.Base;
using CalorieTracker.Client.Entities;

namespace CalorieTracker.Client.Contracts.Interfaces;

public interface IUserRepository : IRepositoryBase<User>
{
    public Task<IEnumerable<User>> GetUserAdvancedDataAsync();
}
