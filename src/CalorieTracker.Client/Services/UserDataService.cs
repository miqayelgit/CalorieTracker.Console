using CalorieTracker.Client.Contracts.Services;
using CalorieTracker.Client.DTOs.UserDataDTOs;
using CalorieTracker.Client.Entities;
using CalorieTracker.Client.UOW;

namespace CalorieTracker.Client.Services;

public class UserDataService : IUserDataService
{
    private readonly UnitOfWork _unitOfWork;

    public UserDataService(UnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    public async Task FillUserData(FillUserDataDTO addUserDataDTO)
    {
        UserData userData = new UserData
        {
            Id = addUserDataDTO.Id,
            ActivityLevelId = addUserDataDTO.ActivityLevelId,
            FitnessGoalId = addUserDataDTO.FitnessGoalId,
            Height = addUserDataDTO.Height,
            Weight = addUserDataDTO.Weight,
            Age = addUserDataDTO.Age,
        };

        _unitOfWork.UserDataRepository.Create(userData);
        await _unitOfWork.CommitAsync();
    }
}
