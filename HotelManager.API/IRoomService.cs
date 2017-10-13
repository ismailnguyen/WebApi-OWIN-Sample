using System.Collections.Generic;

namespace HotelManager.API
{
    public interface IRoomService
    {
        IList<Room> GetAvailableRooms();

        Room BookRoom(int roomNumber);

        Room GetRoom(int roomNumber);
    }
}