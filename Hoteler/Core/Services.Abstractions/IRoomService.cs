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
        Task<IEnumerable<RoomDto>> GetRoomsByHotelId(int hotelId, CancellationToken cancellationToken = default);
        /// <summary>
        /// получить перечисление свободных номеров в отеле по датам въезда и отъезда
        /// </summary>
        /// <param name="hotelId">id отеля</param>
        /// <param name="arrivalDate">дата прибытия</param>
        /// <param name="depatureDate">дата отбытия</param>
        /// <returns></returns>
        Task<IEnumerable<RoomDto>> GetRoomsByHotelIdAndRoomStatus(
            int hotelId, DateTime arrivalDate, DateTime depatureDate, CancellationToken cancellationToken = default);
    }
}
