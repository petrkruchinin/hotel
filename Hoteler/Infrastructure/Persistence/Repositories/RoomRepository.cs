using Domain.Entities.HotelAggregate;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class RoomRepository : IRoomRepository
    {
        private readonly RepositoryDbContext _dbContext;
        public RoomRepository(RepositoryDbContext dbContext) => _dbContext = dbContext;

        public async Task<IEnumerable<Room>> GetRoomsInHotelAsync(Guid hotelId, CancellationToken cancellationToken = default)
        {
            var roomInHotel = await _dbContext.Rooms.Where(t => t.HotelId == hotelId)
                .ToListAsync(cancellationToken);

            return roomInHotel; 
        }

       
    }


    
}

