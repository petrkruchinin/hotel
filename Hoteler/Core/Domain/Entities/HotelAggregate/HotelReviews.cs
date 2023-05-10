using Domain.Common;
using Domain.Entities.UserAggregate;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.HotelAggregate
{
    public class HotelReviews : Entity
    {
        /// <summary>
        /// отзыв
        /// </summary>
        public string Review { get; private set; }
        /// <summary>
        /// оценка отеля
        /// </summary>
        public HotelGrades Grade { get; private set; }
        /// <summary>
        /// признак анонимного отзыва
        /// </summary>
        public bool IsAnonymusReview { get; private set; }
        /// <summary>
        /// id пользователя оставившего отзыв
        /// </summary>
        public Guid? ReviewerId { get; private set; }
        /// <summary>
        /// отель которому принадлежит отзыв
        /// </summary>
        public Guid HotelId { get; private set; }
        /// <summary>
        /// ссылка на пользователя оставившего отзыв
        /// </summary>
        public virtual User? Reviewer { get; private set; }
    }
}
