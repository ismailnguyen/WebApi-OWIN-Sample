using Swashbuckle.Swagger.Annotations;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;

namespace HotelManager.API
{
    [RoutePrefix("api/room")]
    public class RoomController : ApiController
    {
        private readonly IRoomService roomService;

        public RoomController(IRoomService roomService)
        {
            this.roomService = roomService;
        }

        [Route]
        public IList<Room> Get()
        {
            return roomService.GetAvailableRoomNumbers();
        }

        [Route("{id}")]
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var room = roomService.GetRoom(id);
            
            if (room == null)
            {
                return BadRequest();
            }

            return Ok(room);
        }

        [Route]
        [HttpPost]
        [SwaggerResponse(HttpStatusCode.Created, "Room created", typeof(string))]
        public IHttpActionResult Post([FromBody] int roomNumber)
        {
            roomService.AddRoom(roomNumber);

            return Ok();
        }
    }
}
