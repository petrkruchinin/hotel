using Domain.Entities.HotelAggregate;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Configuration
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.ToTable("Hotel");

            builder.HasKey(x => x.Id);

            builder.Property(t => t.Name).IsRequired();
            builder.Property(t => t.Town).IsRequired();
            builder.Property(t => t.FullAddress).IsRequired();

            builder.Property(t => t.Category)
                .HasConversion(v => v.ToString(), v => (HotelCategories)Enum.Parse(typeof(HotelCategories), v))

            builder.HasMany(t => t.Rooms)
                .WithOne()
                .HasForeignKey(t => t.HotelId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(t => t.HotelReviews)
                .WithOne()
                .HasForeignKey(t => t.HotelId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
