

using CalorieTracker.Client.DTOs;
using CalorieTracker.Client.Entities;
using CalorieTracker.Client.Helper;
using CalorieTracker.Client.UOW;

namespace CalorieTracker.Client.Services
{
    public class UserService
    {
        private readonly UnitOfWork _unitOfWork;
        public UserService(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<int> SignUp(SignUpDTO signUpDTO)
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
    

            _unitOfWork.UserRepository.Create(user);
            return await _unitOfWork.CommitAsync();
        }

        public async Task<bool> SignIn(SignInDTO signInDTO)
        {
            User user = await _unitOfWork.UserRepository.GetAsync(x => x.UserName == signInDTO.UserName) ?? throw new InvalidOperationException();

            return PasswordHashGenerator.VerifyKey(signInDTO.Password, user.PasswordHash, user.PasswordSalt);
        }

    }
}
