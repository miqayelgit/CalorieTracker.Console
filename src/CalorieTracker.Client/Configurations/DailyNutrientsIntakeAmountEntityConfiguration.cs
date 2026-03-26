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

            builder.HasOne(x => x.User)
                .WithMany()
                .HasForeignKey(x => x.Id);

            builder.Property(x => x.Protein)
                .HasColumnType("SMALLINT")
                .IsRequired();

            builder.Property(x => x.Fat)
                .HasColumnType("SMALLINT")
                .IsRequired();

            builder.Property(x => x.Carbs)
               .HasColumnType("SMALLINT")
               .IsRequired();
        }
    }
}
