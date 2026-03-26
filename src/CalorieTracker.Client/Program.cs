

using CalorieTracker.Client;
using CalorieTracker.Client.Entities;
using CalorieTracker.Client.Helper;
using CalorieTracker.Client.Repositories;
using CalorieTracker.Client.UnitOfWork;

PasswordHashGenerator.CreateHash("Password1", out byte[] hash, out byte[] salt);

User user = new User
{
    FirstName = "Tsest",
    LastName = "Tesstyan",
    Email = "Tesst@Gmail3.com",
    UserName = "JustCreated",
    PasswordHash = hash,
    PasswordSalt = salt,
    CreatedAt = DateTime.Now,
};

DatabaseContext context = new DatabaseFactory().CreateDbContext([]);
UserRepository userRepository = new UserRepository(context);
DailyCalorieLimitRepository dailyCalorieLimitRepository = new DailyCalorieLimitRepository(context);


User myUser = await userRepository.GetUserByUsername("TesstUsername");

DailyCalorieLimit limit = new()
{
    Id = myUser.Id,
    DailyLimit = 10,
    UsedLimit = 2,
    RemainingLimit = 8
};


UnitOfWork unitOfWork = new UnitOfWork(context, userRepository, dailyCalorieLimitRepository);
unitOfWork.UserRepository.RegisterUser(user);
unitOfWork.DailyCalorieLimitRepository.AddLimits(limit);

IEnumerable<DailyCalorieLimit> limits = await dailyCalorieLimitRepository.GetAll();

await unitOfWork.Commit();

limits = await dailyCalorieLimitRepository.GetAll();


Console.WriteLine();
