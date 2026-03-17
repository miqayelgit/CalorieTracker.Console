using CalorieTracker.Client.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CalorieTracker.Client.Configurations
{
    public class UserDataEntityConfiguration : IEntityTypeConfiguration<UserData>
    {
        public void Configure(EntityTypeBuilder<UserData> builder)
        {
            builder.ToTable("UserData");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Height)
                .HasColumnType("SMALLINT")
                .IsRequired();

            builder.Property(x => x.Weight)
                .HasColumnType("SMALLINT")
                .IsRequired();

            builder.Property(x => x.Age)
                .HasColumnType("TINYINT")
                .IsRequired();

            builder.Property(x => x.ActivityLevel)
                .HasMaxLength(256)
                .IsRequired();

            builder.Property(x => x.FitnessGoal)
                .HasMaxLength (256) 
                .IsRequired();
        }
    }
}
