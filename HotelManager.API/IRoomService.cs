using System.Collections.Generic;

namespace HotelManager.API
{
    public interface IRoomService
    {
        IList<Room> GetAvailableRoomNumbers();

        Room AddRoom(int roomNumber);

        Room GetRoom(int roomNumber);
    }
}