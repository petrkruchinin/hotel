using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enums
{
    /// <summary>
    /// статус комнаты в отеле
    /// </summary>
    public enum RoomStatuses : byte
    {
        Unknown = 0,
        FreeRoom = 1, 
        BusyRoom = 3,
        Renovation = 4,
        ExpectingGuestsToday = 5,
        NeedToCleanRoom = 6
    }
}
