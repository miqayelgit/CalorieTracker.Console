using CalorieTracker.Client.DTOs.RoleDTOs;
using CalorieTracker.Client.DTOs.UserDTOs;
using CalorieTracker.Client.Entities;
using CalorieTracker.Client.Enums;
using CalorieTracker.Client.Helper;
using CalorieTracker.Client.UOW;
using Microsoft.EntityFrameworkCore;

namespace CalorieTracker.Client.Services
{
    public class UserService
    {
        private readonly UnitOfWork _unitOfWork;
        public UserService(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task SignUp(SignUpDTO signUpDTO)
        {
            PasswordHashGenerator.CreateHash(signUpDTO.Password, out byte[] hash, out byte[] salt);

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

            Role role = await _unitOfWork.RoleRepository.FirstOrDefaultAsync(x => x.RoleType == signUpDTO.RoleType);

            if (role == null)
            {

                role = new() { RoleType = signUpDTO.RoleType };
                _unitOfWork.RoleRepository.Create(role);
            }

            UserRole userRole = new UserRole
            {
                User = user,
                Role = role
            };


            _unitOfWork.UserRepository.Create(user);
            _unitOfWork.UserRolesRepository.Create(userRole);
            await _unitOfWork.CommitAsync();
        }

        public async Task<bool> SignIn(SignInDTO signInDTO)
        {
            User user = await _unitOfWork.UserRepository.FirstOrDefaultAsync(x => x.UserName == signInDTO.UserName) ?? throw new InvalidOperationException();

            return PasswordHashGenerator.VerifyKey(signInDTO.Password, user.PasswordHash, user.PasswordSalt);
        }

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            return await _unitOfWork.UserRepository.GetAllAsync();
        }

        public async Task<IEnumerable<User>> GetUserAllData()
        {
            return  await _unitOfWork.UserRepository.GetAllData()
                .Include(x => x.UserData)
                    .ThenInclude(x => x.FitnessGoal)
                .Include(x => x.UserData)
                    .ThenInclude(x => x.ActivityLevel)
                .Include(x => x.UserRoles)
                    .ThenInclude(x => x.Role)
                .Include(x => x.Products)
                .Include(x => x.DailyCalorieLimits)
                .Include(x => x.DailyNutrientsIntakeAmounts).ToListAsync();
        }

    }
}
