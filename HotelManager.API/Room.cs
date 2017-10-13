using System.ComponentModel.DataAnnotations;

namespace HotelManager.API
{
    public class Room
    {
        [Required, Range(0, 100, ErrorMessage = "Numéro de chambre invalide.")]
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