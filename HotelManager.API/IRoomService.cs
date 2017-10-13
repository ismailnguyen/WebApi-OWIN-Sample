using System.Collections.Generic;

namespace HotelManager.API
{
    public interface IRoomService
    {
        IList<Room> GetAvailableRoomNumbers();

        void AddRoom(int roomNumber);

        Room GetRoom(int roomNumber);
    }
}