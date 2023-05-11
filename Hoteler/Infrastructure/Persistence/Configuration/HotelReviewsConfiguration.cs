using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domain.Entities.HotelAggregate;
using Domain.Enums;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration
{
    public class HotelReviewsConfiguration : IEntityTypeConfiguration<HotelReviews>
    {
        public void Configure(EntityTypeBuilder<HotelReviews> builder)
        {
            builder.ToTable("HotelReviews");

            builder.HasKey(x => x.Id);

            builder.Property(t => t.Review).IsRequired();
            builder.Property(t => t.Grade)
                .HasConversion(v => v.ToString(), v => (HotelGrades)Enum.Parse(typeof(HotelGrades), v))
                .IsRequired();

            builder.Property(t => t.IsAnonymusReview).IsRequired();

            builder.HasOne(t => t.Reviewer)
               .WithMany()
               .HasForeignKey(t => t.ReviewerId)
               .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
