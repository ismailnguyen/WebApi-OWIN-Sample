using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Http;

namespace HotelManager.API
{
    [RoutePrefix("api")]
    public class RoomController : ApiController
    {
        private readonly IRoomService roomService;

        public RoomController(IRoomService roomService)
        {
            this.roomService = roomService;
        }

        public IList<string> Get()
        {
            return roomService.GetAvailableRoomNumbers();
        }
    }
}
