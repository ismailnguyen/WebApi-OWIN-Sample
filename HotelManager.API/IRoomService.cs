using System.Collections.Generic;

namespace HotelManager.API
{
    public interface IRoomService
    {
        IList<string> GetAvailableRoomNumbers();
    }
}