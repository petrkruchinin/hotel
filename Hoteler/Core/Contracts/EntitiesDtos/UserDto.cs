using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.EntitiesDtos
{
    public class UserDto
    {
        public Guid Id { get; set; }
        /// <summary>
        /// имя
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// фамилия
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// дата рождения
        /// </summary>
        public DateTime DateOfBirth { get; set; }
        /// <summary>
        /// почта 
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// номер телефона
        /// </summary>
        public string PhoneNumber { get; set; }
    }
}
