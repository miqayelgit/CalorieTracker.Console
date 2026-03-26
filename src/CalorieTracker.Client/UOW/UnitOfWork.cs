

using CalorieTracker.Client.Interfaces;
using CalorieTracker.Client.Repositories;

namespace CalorieTracker.Client.UOW;

 public class UnitOfWork (DatabaseContext context)
{

    private readonly DatabaseContext _context = context;

    private IUserRepository? _userRepository;
    private IDailyCalorieLimitRepository? _dailyCalorieLimitRepository;
    private IActivityLevelRepository? _activityLevelRepository;

    public IUserRepository UserRepository 
    {
        get 
        {
            _userRepository ??=  new UserRepository(_context);
           return _userRepository;
            
        } 
    }

    public IDailyCalorieLimitRepository DailyCalorieLimitRepository
    {
        get
        {
            _dailyCalorieLimitRepository ??=  new DailyCalorieLimitRepository(_context);
            return _dailyCalorieLimitRepository;
        }
    }

    public IActivityLevelRepository ActivityLevelRepository
    {
        get
        {
            _activityLevelRepository ??=  new ActivityLevelRepository(_context);
            return _activityLevelRepository;
        }
    }

    public async Task<int> CommitAsync()
    {
        return await _context.SaveChangesAsync();
    }
}
