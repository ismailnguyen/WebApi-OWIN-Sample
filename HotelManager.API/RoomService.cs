using System.Collections.Generic;
using System.Linq;

namespace HotelManager.API
{
    public class RoomService : IRoomService
    {
        private IList<Room> rooms = new List<Room>();

        public RoomService()
        {
            rooms.Add(Room.FromNumber(1));
            rooms.Add(Room.FromNumber(2));
            rooms.Add(Room.FromNumber(3));
        }

        public IList<Room> GetAvailableRoomNumbers()
        {
            return rooms;
        }

        public Room AddRoom(int roomNumber)
        {
            var room = Room.FromNumber(roomNumber);

            rooms.Add(room);

            return room;
        }

        public Room GetRoom(int roomNumber)
        {
            return rooms?.FirstOrDefault(r => r.RoomNumber == roomNumber);
        }
    }
}
