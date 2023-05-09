using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.EntitiesDtos
{
    public class RoomDto
    {
        public int Id { get; set; }
        /// <summary>
        /// этаж
        /// </summary>
        public int Floor { get; set; }
        /// <summary>
        /// название комнаты
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// описание комнаты
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
        /// id отеля, к которому привязан номер
        /// </summary>
        public int HotelId { get; set; }
        public HotelDto Hotel { get; set; }

    }
}
