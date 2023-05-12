using Contracts.EntitiesDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstractions
{
    public interface IRoomService
    {
        /// <summary>
        /// получить все номера по id отеля 
        /// </summary>
        /// <param name="hotelId">id отеля</param>
        /// <returns>перечисление всех номеров в отеле</returns>
        Task<IEnumerable<RoomDto>> GetRoomsByHotelIdAsync(Guid hotelId, CancellationToken cancellationToken = default);
        
    }
}
