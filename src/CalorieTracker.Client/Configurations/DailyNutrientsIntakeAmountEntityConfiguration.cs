using CalorieTracker.Client.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CalorieTracker.Client.Configurations
{
    public class DailyNutrientsIntakeAmountEntityConfiguration : IEntityTypeConfiguration<DailyNutrientsIntakeAmount>
    {
        public void Configure(EntityTypeBuilder<DailyNutrientsIntakeAmount> builder)
        {
            builder.ToTable("DailyNutrientsIntakeAmounts");

            builder.HasKey(x => x.Id);

            builder.HasOne(d => d.User)
                .WithMany(u => u.DailyNutrientsIntakeAmounts)
                .HasForeignKey(d => d.UserId);

            builder.Property(x => x.Protein)
                .IsRequired();

            builder.Property(x => x.Fat)
                .IsRequired();

            builder.Property(x => x.Carbs)
               .IsRequired();
        }
    }
}
