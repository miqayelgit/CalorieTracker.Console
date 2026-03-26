

using CalorieTracker.Client.Entities;

namespace CalorieTracker.Client.Interfaces;

public interface IUserRepository
{
  public IEnumerable<User> GetAllUsers();
  public User GetUserByUsername(string username);
}
