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

            builder.HasOne(ud => ud.User)
                .WithOne(u => u.UserData)
                .HasForeignKey<UserData>(x => x.Id);

            builder.Property(x => x.Height)
                .IsRequired();

            builder.Property(x => x.Weight)
                .IsRequired();

            builder.Property(x => x.Age)
                .IsRequired();

            builder.Property(x => x.ActivityLevelId)
                .HasMaxLength(256)
                .IsRequired();

            builder.Property(x => x.FitnessGoalId)
                .HasMaxLength (256) 
                .IsRequired();
        }
    }
}
