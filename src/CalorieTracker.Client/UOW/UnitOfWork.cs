

using CalorieTracker.Client.Contracts.Interfaces;
using CalorieTracker.Client.Repositories;

namespace CalorieTracker.Client.UOW;

public class UnitOfWork (DatabaseContext context)
{

    private readonly DatabaseContext _context = context;

    private IUserRepository? _userRepository;
    private IDailyCalorieLimitRepository? _dailyCalorieLimitRepository;
    private IActivityLevelRepository? _activityLevelRepository;
    private IRoleRepository? _roleRepository;
    private IUserRolesRepository? _userRolesRepository;
    private IUserDataRepository? _userDataRepository;
    private IFitnessGoalRepository? _fitnessGoalRepository;
    private IProductRepository? _productRepository;

    public IUserRepository UserRepository => _userRepository ??= new UserRepository(_context);
    public IRoleRepository RoleRepository => _roleRepository ??= new RoleRepository(_context);
    public IDailyCalorieLimitRepository DailyCalorieLimitRepository => _dailyCalorieLimitRepository ??= new DailyCalorieLimitRepository(_context);
    public IActivityLevelRepository ActivityLevelRepository => _activityLevelRepository ??= new ActivityLevelRepository(_context);
    public IUserRolesRepository UserRolesRepository => _userRolesRepository ??= new UserRolesRepository(_context);
    public IUserDataRepository UserDataRepository => _userDataRepository ??= new UserDataRepository(_context);
    public IFitnessGoalRepository FitnessGoalRepository => _fitnessGoalRepository ??= new FitnessGoalRepository(_context);
    public IProductRepository ProductRepository => _productRepository ??= new ProductRepository(_context);
 
    public async Task<int> CommitAsync()
    {
        return await _context.SaveChangesAsync();
    }
}
