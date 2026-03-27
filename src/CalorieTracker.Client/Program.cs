

using CalorieTracker.Client;
using CalorieTracker.Client.DTOs;
using CalorieTracker.Client.Entities;
using CalorieTracker.Client.Services;
using CalorieTracker.Client.UOW;


DatabaseContext context = new DatabaseFactory().CreateDbContext([]);
UnitOfWork unitOfWork = new UnitOfWork(context);


int random = Random.Shared.Next(1, 500);
string password = "Password1";


SignUpDTO signUpDTO = new SignUpDTO
{
    FirstName = null,
    LastName = $"Tesstyan{random}",
    Email = $"Test{random}@Gmail.com",
    UserName = $"JustCreated{random}",
    Password = password
};

SignInDTO signInDTO = new SignInDTO
{
    UserName = "JustCreated12",
    Password = password
};


UserService userService = new UserService(unitOfWork);
//await userService.SignUp(signUpDTO);



bool isLoginSuccessfull = await userService.SignIn(signInDTO);

Console.WriteLine(isLoginSuccessfull);
