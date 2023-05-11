using Domain.Common;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.HotelAggregate
{
    /// <summary>
    /// номер в отеле
    /// </summary>
    public class Room : Entity
    {
        /// <summary>
        /// этаж
        /// </summary>
        public int? Floor { get; private set; }
        /// <summary>
        /// название номера
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// описание номера
        /// </summary>
        public string Description { get; private set; }
        /// <summary>
        /// номер комнаты
        /// </summary>
        public string Number { get; private set; }
        /// <summary>
        /// текущий статус номера 
        /// </summary>
        public RoomStatuses CurrentRoomStatus { get; private set; }
        /// <summary>
        /// отель, которому принадлежит номер
        /// </summary>
        public Guid HotelId { get; private set; }

        /// <summary>
        /// забронированные даты
        /// </summary>
        public virtual ICollection<BookedByDatesRooms> BookedByDatesRooms { get; private set; }



    }
}
