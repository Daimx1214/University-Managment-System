using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{
    public class RoomController : BaseController
    {
        private readonly RoomServices _RoomService;

        public RoomController(RoomServices RoomService)
        {
            _RoomService = RoomService;
        }

        [HttpPost("Post")]
        public ActionResult Post([FromForm] RoomRequestDTO request)
        {
            return new JsonResult(new { success = true, data = _RoomService.AddRoom(request), message = "Created Successfully" });
        }

        [HttpGet("Get")]
        public ActionResult GetAllRoom()
        {
            return new JsonResult(new
            {
                success = true,
                data = _RoomService.GetAll(),
                message = "Retrieved successfully"
            });
        }

        [HttpPost("Delete/{Id}")]
        public IActionResult Delete([FromForm] RoomRequestDTO request)
        {
            return new JsonResult(new
            {
                success = true,
                data = _RoomService.RemoveRoom(request.Id),
                message = "Deleted successfully"
            });
        }
    }
}
