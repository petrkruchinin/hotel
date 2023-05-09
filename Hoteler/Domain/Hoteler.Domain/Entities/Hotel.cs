using Hoteler.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoteler.Domain.Entities
{
    /// <summary>
    /// Отель
    /// </summary>
    public class Hotel
    {
        public int Id { get; private set; }
        /// <summary>
        /// название отеля
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// месторасположение отеля
        /// </summary>
        public string Location { get; private set; }
        /// <summary>
        /// категория отеля
        /// </summary>
        public HotelCategories Category { get; private set; }

        /// <summary>
        /// номера в отеле
        /// </summary>
        public virtual ICollection<Room> Rooms { get; private set; }
        

    }
}
