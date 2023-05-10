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
        Task<IEnumerable<Room>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<Room> GetByIdAsync(int id, CancellationToken cancellationToken = default);
        void Insert(Room room);
        void Remove(Room room);
    }
}
