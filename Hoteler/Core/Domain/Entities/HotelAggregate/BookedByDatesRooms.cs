using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Common;
using Domain.Entities.UserAggregate;

namespace Domain.Entities.HotelAggregate
{
    /// <summary>
    /// забронированные по датам номера
    /// </summary>
    public class BookedByDatesRooms : Entity
    {
        /// <summary>
        /// дата брони
        /// </summary>
        public DateTime BookedDate { get; private set; }
        /// <summary>
        /// признак брони
        /// </summary>
        public bool IsBooked { get; private set; }
        /// <summary>
        /// комната, к которой привязана бронь
        /// </summary>
        public virtual Room Room { get; private set; }
        /// <summary>
        /// ссылка на пользователя, забронировавшего номер
        /// </summary>
        public virtual User BookingUser { get; private set; }

    }
}
