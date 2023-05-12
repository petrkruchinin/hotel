using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.EntitiesDtos
{
    public class BookedByDatesRoomsDto
    {
        public Guid Id { get; set; }
        /// <summary>
        /// дата брони
        /// </summary>
        public DateTime BookedDate { get; set; }
        /// <summary>
        /// признак брони
        /// </summary>
        public bool IsBooked { get; set; }
        /// <summary>
        /// ссылка на пользователя, забронировавшего номер
        /// </summary>
        public virtual UserDto BookingUser { get; set; }
        /// <summary>
        /// ссылка на пользователя, забронировавшего номер id
        /// </summary>
        public Guid BookingUserId { get; set; }

    }
}
