using CalorieTracker.Client.Contracts.Services;
using CalorieTracker.Client.DTOs.RoleDTOs;
using CalorieTracker.Client.DTOs.UserDTOs;
using CalorieTracker.Client.Entities;
using CalorieTracker.Client.Enums;
using CalorieTracker.Client.Helper;
using CalorieTracker.Client.UOW;
using Microsoft.EntityFrameworkCore;

namespace CalorieTracker.Client.Services
{
    public class UserService : IUserService
    {
        private readonly UnitOfWork _unitOfWork;
        public UserService(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task SignUp(SignUpDTO signUpDTO)
        {
            PasswordHashGenerator.CreateHash(signUpDTO.Password, out byte[] hash, out byte[] salt);

            if (await _unitOfWork.UserRepository.IsUserAlreadyCreatedAsync(signUpDTO.Email))
            {
                Console.WriteLine("User already exists!!");
                return;
            }

                User user = new User
            {
                FirstName = signUpDTO.FirstName,
                LastName = signUpDTO.LastName,
                UserName = signUpDTO.UserName,
                Email = signUpDTO.Email,
                PasswordHash = hash,
                PasswordSalt = salt,
                CreatedAt = DateTime.Now
            };

            _unitOfWork.UserRepository.Create(user);
            await _unitOfWork.CommitAsync();
        }

        public async Task CreateAdmin(SignUpDTO signUpDTO)
        {

            if (await _unitOfWork.UserRepository.IsAdminUserPresentAsync())
            {
                Console.WriteLine("Admin user already created");
                return;
            }

            PasswordHashGenerator.CreateHash(signUpDTO.Password, out byte[] hash, out byte[] salt);

            if (await _unitOfWork.UserRepository.IsUserAlreadyCreatedAsync(signUpDTO.Email))
            {
                Console.WriteLine("User already exists!!");
                return;
            }

            User user = new User
            {
                FirstName = signUpDTO.FirstName,
                LastName = signUpDTO.LastName,
                UserName = signUpDTO.UserName,
                Email = signUpDTO.Email,
                PasswordHash = hash,
                PasswordSalt = salt,
                CreatedAt = DateTime.Now
            };

            _unitOfWork.UserRepository.Create(user);
            await _unitOfWork.CommitAsync();
        }

        public async Task<bool> SignIn(SignInDTO signInDTO)
        {
            User user = await _unitOfWork.UserRepository.FirstOrDefaultAsync(x => x.UserName == signInDTO.UserName) ?? throw new InvalidOperationException();

            return PasswordHashGenerator.VerifyKey(signInDTO.Password, user.PasswordHash, user.PasswordSalt);
        }

        public async Task<List<UserAdvancedDataDTO>> GetAllUsersAdvancedAsync()
        {
            IEnumerable<User> usersList = await _unitOfWork.UserRepository.GetUserAdvancedDataAsync();

            if (usersList == null)
            {
                throw new InvalidOperationException();
            }

            return usersList.Select(x => new UserAdvancedDataDTO
            {
                Id = x.Id,
                Height = x.UserData.Height,
                Weight = x.UserData.Weight,
                ActivityLevelName = x.UserData.ActivityLevel.ActivityLevelName,
                FitnessGoalName = x.UserData.FitnessGoal.GoalName,
                Age = x.UserData.Age,   
                DailyCalorieLimits = x.DailyCalorieLimits.ToList(),
                DailyNutrientsIntakeAmounts = x.DailyNutrientsIntakeAmounts.ToList(),
                UserRoles = x.UserRoles.ToList(),

            }).ToList();
        }

        public async Task<UserProfileDTO> GetUserProfileByIdAsync(Guid id)
        {
            User user = await _unitOfWork.UserRepository.FirstOrDefaultAsync(x => x.Id == id);

            UserProfileDTO userProfile = new UserProfileDTO
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                UserName = user.UserName,
                Email = user.Email
            };

            return userProfile;
        }

    }
}
