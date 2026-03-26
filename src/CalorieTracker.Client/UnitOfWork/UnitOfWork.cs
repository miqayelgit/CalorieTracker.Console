

using CalorieTracker.Client.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CalorieTracker.Client.UnitOfWork;

 public class UnitOfWork
{

    private DatabaseContext _context;
    public IUserRepository UserRepository;
    public IDailyCalorieLimitRepository DailyCalorieLimitRepository;
    public UnitOfWork(
        DatabaseContext context, 
        IUserRepository userRepository,
        IDailyCalorieLimitRepository dailyCalorieLimitRepository)
    {
        _context = context;
        UserRepository = userRepository;
        DailyCalorieLimitRepository = dailyCalorieLimitRepository;

    }
    public async Task<int> Commit()
    {
        return await _context.SaveChangesAsync();
    }

}
