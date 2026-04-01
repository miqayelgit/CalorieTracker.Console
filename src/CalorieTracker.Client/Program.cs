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


DatabaseContext context = new DatabaseFactory().CreateDbContext([]);
UnitOfWork unitOfWork = new UnitOfWork(context);
RoleService roleService = new RoleService(unitOfWork);
UserService userService = new UserService(unitOfWork);



List<UserAdvancedDataDTO> users = await userService.GetAllUsersAsync();
List<GetRolesDTO> roles = await roleService.GetRolesAsync();

//if(!users.Any(x => x.UserRoles.Select(x => x.Role.RoleType == RolesTypes.Admin).FirstOrDefault()))
//{ 
//    SignUpDTO signUpDTO = new SignUpDTO
//        {
//            FirstName = "Admin",
//            LastName = "Adminyan",
//            UserName = "MainAdmin",
//            Email = "Admin@gmail.com",
//            Password = "Password",
//            RoleType = RolesTypes.Admin
//        };

//    await userService.SignUp(signUpDTO);
    
//}

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



