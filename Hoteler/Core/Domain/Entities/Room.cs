using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    /// <summary>
    /// комната в отеле
    /// </summary>
    public class Room
    {
        public int Id { get; private set; }
        /// <summary>
        /// этаж
        /// </summary>
        public int Floor { get; private set; }
        /// <summary>
        /// название комнаты
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// описание комнаты
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
        /// id отеля, к которому привязан номер
        /// </summary>
        public int HotelId { get; private set; }
        /// <summary>
        /// ссылка на отель, к которому привязан номер
        /// </summary>
        public virtual Hotel Hotel { get; private set; }



    }
}
