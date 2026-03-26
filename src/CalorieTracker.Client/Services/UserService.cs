

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

        public void SignUp(User user, string password)
        {
            PasswordHashGenerator.CreateHash(password, out byte[] hash, out byte[] salt);
            user.PasswordHash = hash;
            user.PasswordSalt = salt;

            _unitOfWork.UserRepository.Create(user);
        }

        public async Task<bool> SignIn(string userName, string password)
        {
            User user = await _unitOfWork.UserRepository.GetUserByUsername(userName) ?? throw new InvalidOperationException();

            if (PasswordHashGenerator.VerifyKey(password, user.PasswordHash, user.PasswordSalt))
            {
                return true;
            }
           
            return false;
        }

    }
}
