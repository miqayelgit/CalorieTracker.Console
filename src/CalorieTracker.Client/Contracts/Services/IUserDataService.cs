using CalorieTracker.Client.DTOs.UserDataDTOs;

namespace CalorieTracker.Client.Contracts.Services;

public interface IUserDataService
{
    public Task FillUserData(FillUserDataDTO addUserDataDTO);
}
