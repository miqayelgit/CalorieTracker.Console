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

            builder.HasOne(x => x.User)
                .WithMany()
                .HasForeignKey(x => x.Id);

            builder.Property(x => x.UsedLimit)
                .HasColumnType("SMALLINT")
                .IsRequired();

            builder.Property(x => x.RemainingLimit)
                .HasColumnType("SMALLINT")
                .IsRequired();

            builder.Property(x => x.CreatedDate)
                .IsRequired()
                .HasDefaultValue(DateTime.Now);
        }
    }
}
