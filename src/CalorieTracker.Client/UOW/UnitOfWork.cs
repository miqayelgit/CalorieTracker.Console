

using CalorieTracker.Client.Interfaces;
using CalorieTracker.Client.Repositories;

namespace CalorieTracker.Client.UOW;

 public class UnitOfWork (DatabaseContext context)
{

    private readonly DatabaseContext _context = context;

    private IUserRepository? _userRepository;
    private IDailyCalorieLimitRepository? _dailyCalorieLimitRepository;
    private IActivityLevelRepository? _activityLevelRepository;

    public IUserRepository UserRepository => _userRepository ??= new UserRepository(_context);
    public IDailyCalorieLimitRepository DailyCalorieLimitRepository => _dailyCalorieLimitRepository ??= new DailyCalorieLimitRepository(_context);
    public IActivityLevelRepository ActivityLevelRepository => _activityLevelRepository ??= new ActivityLevelRepository(_context);
 
    public async Task<int> CommitAsync()
    {
        return await _context.SaveChangesAsync();
    }
}
