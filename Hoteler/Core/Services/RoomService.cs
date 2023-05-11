using Contracts.EntitiesDtos;
using Domain.Repositories;
using Mapster;
using Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Services
{
    public class RoomService : IRoomService
    {
        private readonly IRepositoryManager _repositoryManager;

        public RoomService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public async Task<IEnumerable<RoomDto>> GetRoomsByHotelId(Guid hotelId, CancellationToken cancellationToken = default)
        {
            var allRooms = await _repositoryManager.RoomRepository.GetAllAsync(cancellationToken);
            var roomsInHotel = allRooms.Where(t => t.HotelId == hotelId);

            var roomsInHotelDtos = roomsInHotel.Adapt<IEnumerable<RoomDto>>();

            return roomsInHotelDtos;
        }

        public Task<IEnumerable<RoomDto>> GetRoomsByHotelIdAndRoomStatus(
            Guid hotelId, DateTime arrivalDate, DateTime depatureDate, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
