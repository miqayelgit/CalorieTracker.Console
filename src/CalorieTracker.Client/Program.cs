using CalorieTracker.Client;
using CalorieTracker.Client.DTOs.ProductDTOs;
using CalorieTracker.Client.DTOs.UserDataDTOs;
using CalorieTracker.Client.DTOs.UserDTOs;
using CalorieTracker.Client.Entities;
using CalorieTracker.Client.Enums;
using CalorieTracker.Client.Services;
using CalorieTracker.Client.UOW;
using System.Data;


DatabaseContext context = new DatabaseFactory().CreateDbContext([]);
UnitOfWork unitOfWork = new UnitOfWork(context);
RoleService roleService = new RoleService(unitOfWork);
UserService userService = new UserService(unitOfWork);



IEnumerable<User> users = await userService.GetUserAllData();
IEnumerable<Role> roles = await roleService.GetRolesAllData();

if(!users.Any(x => x.UserRoles.Select(x => x.Role.RoleType == RolesTypes.Admin).FirstOrDefault()))
{ 
    SignUpDTO signUpDTO = new SignUpDTO
        {
            FirstName = "Admin",
            LastName = "Adminyan",
            UserName = "MainAdmin",
            Email = "Admin@gmail.com",
            Password = "Password",
            RoleType = RolesTypes.Admin
        };

    await userService.SignUp(signUpDTO);
    
}

if(!users.Any(x => x.UserRoles.Any(x => x.Role.RoleType != RolesTypes.Admin)))
{
    int random = Random.Shared.Next(1, 500);
    string password = "Password1";

    SignUpDTO signUpDTO = new SignUpDTO
    {
        FirstName = $"Mikayel{random}",
        LastName = $"Mkrtchyan{random}",
        UserName = $"Mkrtchyan{random}",
        Email = $"Mkrtchyan{random}@gmail.com",
        Password = password,
        RoleType = RolesTypes.User
    };

    await userService.SignUp(signUpDTO);
}

User? nonAdminUser = users.FirstOrDefault(x => x.UserRoles.Any(x => x.Role.RoleType == RolesTypes.User));

ActivityLevelService als = new ActivityLevelService(unitOfWork);
IEnumerable<ActivityLevel> levels = await als.GetActivityLevels();

FitnessGoalService fitnessGoalService = new FitnessGoalService(unitOfWork);
IEnumerable<FitnessGoal> goal = await fitnessGoalService.GetFitnessGoalsAsync();

if (nonAdminUser != null && levels != null && goal != null)
{
    FillUserDataDTO fillUserDataDTO = new FillUserDataDTO
    {
        Id = nonAdminUser.Id,
        ActivityLevelId = levels.FirstOrDefault()!.Id,
        FitnessGoalId = goal.FirstOrDefault()!.Id,
        Age = 27,
        Weight = 79,
        Height = 173

    };

}

ProductService ps = new ProductService(unitOfWork);
CreateProductDTO createProductDTO = new CreateProductDTO
{
    Id = new Guid(),
    UserId = nonAdminUser!.Id,
    ProductName = "Chicken Breast",
    CaloriesPerHundredGram = 165,
    CarbsPerHundredGram = 0,
    FatPerHundredGram = 3.6f,
    ProteinPerHundredGram = 31,
    VisibilityScope = VisibilityScope.Public
};

await ps.CreateProduct(createProductDTO);


