using HotelManager.API.Model;
using System.Collections.Generic;

namespace HotelManager.API.Service
{
    public interface IRoomService
    {
        IList<int> GetAvailableRooms();
        IList<Room> GetBookedRooms();

        Room BookRoom(Room room);

        Room GetRoom(int roomNumber);
    }
}