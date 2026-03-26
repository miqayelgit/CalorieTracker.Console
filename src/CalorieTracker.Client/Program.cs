

using CalorieTracker.Client;
using CalorieTracker.Client.Entities;
using CalorieTracker.Client.Repositories;

DatabaseContext context = new DatabaseFactory().CreateDbContext([]);

UserRepository userRepository = new UserRepository(context);

UserRepository ur = new UserRepository(context);

IEnumerable<User> user2 =  ur.GetAllUsers().ToList();

User user3 = ur.GetUserByUsername("testUsername");
Console.WriteLine();

