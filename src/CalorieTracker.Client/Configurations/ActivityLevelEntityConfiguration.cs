using CalorieTracker.Client.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CalorieTracker.Client.Configurations
{
    internal class ActivityLevelEntityConfiguration : IEntityTypeConfiguration<ActivityLevel>
    {
        public void Configure(EntityTypeBuilder<ActivityLevel> builder)
        {
            builder.ToTable("ActivityLevels");

            builder.HasKey(x => x.Id);  

            builder.Property(x => x.ActivityLevelName)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.ActivityLevelRate)
                .HasColumnType("FLOAT")
                .IsRequired();
        }
    }
}
