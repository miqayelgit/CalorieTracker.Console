

using CalorieTracker.Client;
using CalorieTracker.Client.Entities;
using CalorieTracker.Client.Services;
using CalorieTracker.Client.UOW;


int random = Random.Shared.Next(1, 500);
string password = "Password123";

User user = new User
{
    FirstName = $"User{random}",
    LastName = $"Tesstyan{random}",
    Email = $"Test{random}@Gmail.com",
    UserName = $"JustCreated{random}",
    CreatedAt = DateTime.Now,
};

DatabaseContext context = new DatabaseFactory().CreateDbContext([]);
UnitOfWork unitOfWork = new UnitOfWork(context);

UserService userService = new UserService(unitOfWork);

userService.SignUp(user, password);

bool isLoginSuccessfull = await userService.SignIn("JustCreated12", "Password1");
Console.WriteLine(isLoginSuccessfull);

await unitOfWork.CommitAsync(); 