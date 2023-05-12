using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.EntitiesDtos
{
    public class RoomDto
    {
        public Guid Id { get; set; }
        /// <summary>
        /// этаж
        /// </summary>
        public int? Floor { get; set; }
        /// <summary>
        /// название номера
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// описание номера
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// номер комнаты
        /// </summary>
        public string Number { get; set; }
        /// <summary>
        /// текущий статус номера 
        /// </summary>
        public byte CurrentRoomStatus { get; set; }
        /// <summary>
        /// отель, которому принадлежит номер
        /// </summary>
        public Guid HotelId { get; set; }
        /// <summary>
        /// забронированные даты
        /// </summary>
        public virtual ICollection<BookedByDatesRoomsDto> BookedByDatesRooms { get; private set; }

    }
}
