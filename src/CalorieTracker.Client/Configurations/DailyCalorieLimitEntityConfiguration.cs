using CalorieTracker.Client.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CalorieTracker.Client.Configurations
{
    public class DailyCalorieLimitEntityConfiguration : IEntityTypeConfiguration<DailyCalorieLimit>
    {
        public void Configure(EntityTypeBuilder<DailyCalorieLimit> builder)
        {
            builder.ToTable("DailyCalorieLimits");

            builder.HasOne(d => d.User)
                .WithMany(u => u.DailyCalorieLimits)
                .HasForeignKey(u => u.UserId);

            builder.Property(x => x.UsedLimit)
                .IsRequired();

            builder.Property(x => x.RemainingLimit)
                .IsRequired();

            builder.Property(x => x.CreatedDate)
                .IsRequired()
                .HasDefaultValue(DateTime.Now);
        }
    }
}
