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
    /// Отель
    /// </summary>
    public class Hotel : Entity, IAggregateRoot
    {
        /// <summary>
        /// название отеля
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// город, в котором находится отель
        /// </summary>
        public string Town { get; private set; }
        /// <summary>
        /// месторасположение отеля (город + адрес)
        /// </summary>
        public string FullAddress { get; private set; }
        /// <summary>
        /// категория отеля
        /// </summary>
        public HotelCategories Category { get; private set; }

        /// <summary>
        /// номера в отеле
        /// </summary>
        public virtual ICollection<Room> Rooms { get; private set; }
        /// <summary>
        /// отзывы о отеле
        /// </summary>
        public virtual ICollection<HotelReviews> HotelReviews { get; private set; }
    }
}
