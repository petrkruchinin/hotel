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
    public class RoomConfiguration : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.ToTable("Room");

            builder.HasKey(x => x.Id);

            builder.Property(t => t.Name).IsRequired();
            builder.Property(t => t.Number).IsRequired();
            builder.Property(t => t.Floor);
            builder.Property(t => t.Description);
            builder.Property(t => t.CurrentRoomStatus)
                .HasConversion(v => v.ToString(), v => (RoomStatuses)Enum.Parse(typeof(RoomStatuses), v))
                .IsRequired();

            builder.HasMany(t => t.BookedByDatesRooms)
               .WithOne()
               .HasForeignKey(t => t.RoomId)
               .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
