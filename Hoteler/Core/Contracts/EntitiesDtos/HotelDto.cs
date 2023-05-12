using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.EntitiesDtos
{
    public class HotelDto
    {
        public Guid Id { get; set; }
        /// <summary>
        /// название отеля
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// город, в котором находится отель
        /// </summary>
        public string Town { get; set; }
        /// <summary>
        /// месторасположение отеля (город + адрес)
        /// </summary>
        public string FullAddress { get; set; }
        /// <summary>
        /// категория отеля
        /// </summary>
        public byte Category { get; set; }

        /// <summary>
        /// номера в отеле
        /// </summary>
        public virtual ICollection<RoomDto> Rooms { get; set; }
        /// <summary>
        /// отзывы о отеле
        /// </summary>
        public virtual ICollection<HotelReviewsDto> HotelReviews { get; set; }
    }
}
