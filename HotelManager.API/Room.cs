namespace HotelManager.API
{
    public class Room
    {
        public int RoomNumber { get; set; }

        public Room(int roomNumber)
        {
            RoomNumber = roomNumber;
        }

        public static Room FromNumber(int roomNumber)
        {
            return new Room(roomNumber);
        }
    }
}