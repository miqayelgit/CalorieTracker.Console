namespace CalorieTracker.Client.Entities;

public class User
{
    public Guid Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string UserName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public byte[] PasswordHash { get; set; } = [];
    public byte[] PasswordSalt { get; set; } = [];
    public DateTime CreatedAt { get; set; }
    public ICollection<UserRole> UserRoles { get; set; } = [];
    public ICollection<DailyCalorieLimit> DailyCalorieLimits { get; set; } = [];
    public ICollection<DailyNutrientsIntakeAmount> DailyNutrientsIntakeAmounts { get; set; } = [];
    public ICollection<Product> Products { get; set; } = [];
    public UserData UserData { get; set; } = null!;
}