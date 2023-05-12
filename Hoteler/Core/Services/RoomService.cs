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

        public async Task<IEnumerable<RoomDto>> GetRoomsByHotelIdAsync(Guid hotelId, CancellationToken cancellationToken = default)
        {
            try
            {
                var roomsInHotel = await _repositoryManager.RoomRepository.GetRoomsInHotelAsync(hotelId, cancellationToken);

                var roomsInHotelDtos = roomsInHotel.Adapt<List<RoomDto>>();

                return roomsInHotelDtos;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        
    }
}
