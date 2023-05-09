using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.EntitiesDtos
{
    public class HotelDto
    {
        public int Id { get; set; }
        /// <summary>
        /// название отеля
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// месторасположение отеля
        /// </summary>
        public string Location { get; set; }
        /// <summary>
        /// категория отеля
        /// </summary>
        public byte Category { get; set; }

        /// <summary>
        /// номера в отеле
        /// </summary>
        public virtual IEnumerable<RoomDto> Rooms { get; private set; }
    }
}
