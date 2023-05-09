using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoteler.Domain.Entities
{
    /// <summary>
    /// забронированные по датам номера
    /// </summary>
    public class BookedByDatesRooms
    {
        public int Id { get; private set; }
        /// <summary>
        /// дата брони
        /// </summary>
        public DateTime BookedDate { get; private set; }
        /// <summary>
        /// id забронированного номера 
        /// </summary>
        public int RoomId { get; private set; }
        /// <summary>
        /// сслыка на забронированный номер
        /// </summary>
        public virtual Room Room { get; private set; }
        /// <summary>
        /// id отеля, в котором забронирован номер
        /// </summary>
        public int HotelId { get; private set; }
        /// <summary>
        /// ссылка на отель, в котором забронирован номер
        /// </summary>
        public virtual Hotel Hotel { get; private set; }
        /// <summary>
        /// забронировавший номер пользователь
        /// </summary>
        public int BookingUserId { get; private set; }
        /// <summary>
        /// ссылка на пользователя, забронировавшего номер
        /// </summary>
        public virtual User BookingUser { get; private set; }

    }
}
