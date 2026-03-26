

using CalorieTracker.Client.Entities;

namespace CalorieTracker.Client.Interfaces;

public interface IActivityLevelRepository
{
    public void AddActivityLevel(ActivityLevel activityLevel);
}
