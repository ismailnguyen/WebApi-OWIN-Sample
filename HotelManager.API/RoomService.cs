using System.Collections.Generic;

namespace HotelManager.API
{
    public class RoomService : IRoomService
    {
        public IList<string> GetAvailableRoomNumbers()
        {
            return new[]
            {
                "1",
                "2"
            };
        }
    }
}
