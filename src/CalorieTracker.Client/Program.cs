using CalorieTracker.Client;
using CalorieTracker.Client.DTOs.ProductDTOs;
using CalorieTracker.Client.DTOs.RoleDTOs;
using CalorieTracker.Client.DTOs.UserDataDTOs;
using CalorieTracker.Client.DTOs.UserDTOs;
using CalorieTracker.Client.Entities;
using CalorieTracker.Client.Enums;
using CalorieTracker.Client.Services;
using CalorieTracker.Client.UOW;
using System.Data;


var context = new DatabaseFactory().CreateDbContext([]);
var unitOfWork = new UnitOfWork(context);
var roleService = new RoleService(unitOfWork);
var userService = new UserService(unitOfWork);






List<UserAdvancedDataDTO> users = await userService.GetAllUsersAdvancedAsync();
List<GetRolesDTO> roles = await roleService.GetRolesAsync();


SignUpDTO signUpDTO = new SignUpDTO
    {
        FirstName = "Admin",
        LastName = "Adminyan",
        UserName = "MainAdmin",
        Email = "Admin@gmail.com",
        Password = "Password",
        RoleType = RolesType.Admin
    };

await userService.CreateAdmin(signUpDTO);

//if(!users.Any(x => x.UserRoles.Any(x => x.Role.RoleType != RolesTypes.Admin)))
//{
//    int random = Random.Shared.Next(1, 500);
//    string password = "Password1";

//    SignUpDTO signUpDTO = new SignUpDTO
//    {
//        FirstName = $"Mikayel{random}",
//        LastName = $"Mkrtchyan{random}",
//        UserName = $"Mkrtchyan{random}",
//        Email = $"Mkrtchyan{random}@gmail.com",
//        Password = password,
//        RoleType = RolesTypes.User
//    };

//    await userService.SignUp(signUpDTO);
//}



