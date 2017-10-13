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

        public IList<Room> GetAvailableRooms()
        {
            return rooms;
        }

        public Room BookRoom(int roomNumber)
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
