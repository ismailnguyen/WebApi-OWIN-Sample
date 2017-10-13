using System.ComponentModel.DataAnnotations;

namespace HotelManager.API.Model
{
    public class Room
    {
        [Required, Range(1, 99, ErrorMessage = "Numéro de chambre invalide.")]
        public int RoomNumber { get; set; }

        public Guest Guest { get; set; } = new Guest();

        public static Room FromNumber(int roomNumber)
        {
            return new Room() { RoomNumber = roomNumber };
        }
    }
}