using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    /// <summary>
    /// пользователь
    /// </summary>
    public class User
    {
        public int Id { get; private set; }
        /// <summary>
        /// имя
        /// </summary>
        public string FirstName { get; private set; }
        /// <summary>
        /// фамилия
        /// </summary>
        public string LastName { get; private set; }
        /// <summary>
        /// дата рождения
        /// </summary>
        public DateTime DateOfBirth { get; private set; }
        /// <summary>
        /// почта 
        /// </summary>
        public string Email { get; private set; }
        /// <summary>
        /// номер телефона
        /// </summary>
        public string PhoneNumber { get; private set; }
    }
}
