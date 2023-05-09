using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class HotelReviews
    {
        public int Id { get; private set; }
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
        public int? ReviewerId { get; private set; }
        /// <summary>
        /// ссылка на пользователя оставившего отзыв
        /// </summary>
        public virtual User? Reviewer { get; private set; }
        /// <summary>
        /// id отеля
        /// </summary>
        public int HotelId { get; private set; }
        /// <summary>
        /// ссылка на отель
        /// </summary>
        public virtual Hotel Hotel { get; private set; }
    }
}
