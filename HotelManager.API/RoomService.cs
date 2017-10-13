using System.Collections.Generic;
using System.Linq;

namespace HotelManager.API
{
    public class RoomService : IRoomService
    {
        private IList<Room> rooms = new List<Room>();

        public RoomService()
        {
            rooms.Add(new Room() { Number = 2 });
            rooms.Add(new Room() { Number = 3 });
            rooms.Add(new Room() { Number = 4 });
        }

        public IList<Room> GetAvailableRoomNumbers()
        {
            return rooms;
        }

        public void AddRoom(int roomNumber)
        {
            rooms.Add(new Room() { Number = roomNumber });
        }

        public Room GetRoom(int roomNumber)
        {
            return rooms?.FirstOrDefault(r => r.Number == roomNumber);
        }
    }
}
