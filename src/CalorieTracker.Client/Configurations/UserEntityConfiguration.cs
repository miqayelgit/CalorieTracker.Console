using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CalorieTracker.Client.Entities;
using Microsoft.EntityFrameworkCore;

namespace CalorieTracker.Client.Configurations;

public class UserEntityConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("Users");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.FirstName)
            .HasMaxLength(128)
            .IsRequired();

        builder.Property(x => x.LastName)
           .HasMaxLength(256)
           .IsRequired();

        builder.Property(x => x.CreatedAt)
            .HasDefaultValue(DateTime.UtcNow);

        builder.HasIndex(x => x.UserName);

        builder.HasAlternateKey(x => x.Email)
            .HasName("UQ_Users_Email");
    }
}
