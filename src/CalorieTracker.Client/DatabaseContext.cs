using CalorieTracker.Client.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace CalorieTracker.Client;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }

    public DbSet<UserData> UserData { get; set; }

    public DbSet<Product> Products{ get; set; }

    public DbSet<FitnessGoal> FitnessGoals{ get; set; }

    public DbSet<ActivityLevel> ActivityLevels{ get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<DailyCalorieLimit> DailyCalorieLimits { get; set; }
    public DbSet<DailyNutrientsIntakeAmount> DailyNutrientsIntakeAmounts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        base.OnModelCreating(modelBuilder);
    }
}
