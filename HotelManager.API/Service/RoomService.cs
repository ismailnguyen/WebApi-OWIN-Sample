using HotelManager.API.Model;
using System.Collections.Generic;
using System.Linq;

namespace HotelManager.API.Service
{
    public class RoomService : IRoomService
    {
        private IList<Room> rooms = new List<Room>();

        public IList<int> GetAvailableRooms()
        {
            var availableRoomNumbers = new List<int>();
            
            for(int i=1; i<100; i++)
            {
                if (rooms.Select(r => r.RoomNumber).Contains(i))
                {
                    continue;
                }

                availableRoomNumbers.Add(i);
            }

            return availableRoomNumbers;
        }

        public IList<Room> GetBookedRooms()
        {
            return rooms;
        }

        public Room BookRoom(Room room)
        {
            rooms.Add(room);

            return room;
        }

        public Room GetRoom(int roomNumber)
        {
            return rooms?.FirstOrDefault(r => r.RoomNumber == roomNumber);
        }
    }
}
