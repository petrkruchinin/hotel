using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.EntitiesDtos
{
    public class HotelReviewsDto
    {
        /// <summary>
        /// отзыв
        /// </summary>
        public string Review { get; set; }
        /// <summary>
        /// оценка отеля
        /// </summary>
        public byte Grade { get; set; }
        /// <summary>
        /// признак анонимного отзыва
        /// </summary>
        public bool IsAnonymusReview { get; set; }
        /// <summary>
        /// id пользователя оставившего отзыв
        /// </summary>
        public Guid? ReviewerId { get; set; }
        /// <summary>
        /// отель которому принадлежит отзыв
        /// </summary>
        public Guid HotelId { get; set; }
        /// <summary>
        /// ссылка на пользователя оставившего отзыв
        /// </summary>
        public virtual UserDto? Reviewer { get; set; }
    }
}
