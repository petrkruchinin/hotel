using Domain.Entities.HotelAggregate;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IRoomRepository
    {
        Task<IEnumerable<Room>> GetRoomsInHotelAsync(Guid hotelId, CancellationToken cancellationToken = default);

    }
}
