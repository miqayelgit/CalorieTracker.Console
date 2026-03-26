

using CalorieTracker.Client.Entities;

namespace CalorieTracker.Client.Interfaces;

public interface IUserRepository : IRepositoryBase<User>
{
    public Task<IEnumerable<User>> GetAllUsers();
    public Task<User> GetUserByUsername(string username);
}
