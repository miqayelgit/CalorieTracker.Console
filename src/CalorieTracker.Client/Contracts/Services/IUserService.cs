using CalorieTracker.Client.DTOs.UserDTOs;
using CalorieTracker.Client.Entities;

namespace CalorieTracker.Client.Contracts.Services;

public interface IUserService
{
    public Task SignUp(SignUpDTO signUpDTO);
    public Task<bool> SignIn(SignInDTO signInDTO);
    public Task<List<UserAdvancedDataDTO>> GetAllUsersAsync();
    public Task<UserProfileDTO> GetUserProfileByIdAsync(Guid id);
}