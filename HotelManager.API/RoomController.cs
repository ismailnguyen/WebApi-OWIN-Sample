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
            return roomService.GetAvailableRooms();
        }

        [Route("{id}", Name = "GetRoomByIdRoute")]
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var room = roomService.GetRoom(id);
            
            if (room == null)
            {
                return BadRequest("Chambre non trouvée !");
            }

            return Ok(room);
        }

        [Route]
        [HttpPost]
        [SwaggerResponse(HttpStatusCode.Created, "Room created", typeof(string))]
        public IHttpActionResult Post([FromBody] Room room)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bookedRoom = roomService.BookRoom(room.RoomNumber);

            var location = Url.Link("GetRoomByIdRoute", new { id = bookedRoom.RoomNumber });

            return Created(location, bookedRoom);
        }
    }
}
