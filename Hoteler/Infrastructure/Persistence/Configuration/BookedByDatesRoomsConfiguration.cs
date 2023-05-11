using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domain.Entities.HotelAggregate;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration
{
    public class BookedByDatesRoomsConfiguration : IEntityTypeConfiguration<BookedByDatesRooms>
    {
        public void Configure(EntityTypeBuilder<BookedByDatesRooms> builder)
        {
            builder.ToTable("BookedByDatesRooms");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.BookedDate).IsRequired();
            builder.Property(t => t.IsBooked).IsRequired();
            builder.Property(t => t.BookingUserId).IsRequired();


            builder.HasOne(t => t.BookingUser)
                .WithMany()
                .HasForeignKey(t => t.BookingUserId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
