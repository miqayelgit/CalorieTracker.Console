using CalorieTracker.Client.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
