using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Model;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{
    public class RoomTypeController : BaseController
    {
        private readonly RoomTypeServices _RoomTypeService;

        public RoomTypeController(RoomTypeServices RoomTypeService)
        {
            _RoomTypeService = RoomTypeService;
        }

        [HttpPost("Post")]
        public ActionResult Post([FromForm] RoomTypeRequestDTO request)
        {
            return new JsonResult(new { success = true, data = _RoomTypeService.AddRoomType(request), message = "Created Successfully" });
        }
        [HttpGet("Get")]
        public ActionResult GetAllRoomType()
        {
            return new JsonResult(new
            {
                success = true,
                data = _RoomTypeService.GetAll(),
                message = "Retrieved successfully"
            });
        }

        [HttpPost("Delete/{Id}")]
        public IActionResult Delete([FromForm] RoomTypeRequestDTO request)
        {
            return new JsonResult(new
            {
                success = true,
                data = _RoomTypeService.RemoveRoomType(request.Id),
                message = "Deleted successfully"
            });
        }
    }
}