using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{
    public class RoomTypeAllocationController : BaseController
    {
        private readonly RoomTypeAllocationServices _RoomTypeAllocationService;

        public RoomTypeAllocationController(RoomTypeAllocationServices RoomTypeAllocationService)
        {
            _RoomTypeAllocationService = RoomTypeAllocationService;
        }

        [HttpPost("Post")]
        public ActionResult Post([FromForm] RoomTypeAllocationRequestDTO request)
        {
            return new JsonResult(new { success = true, data = _RoomTypeAllocationService.AddRoomTypeAllocation(request), message = "Created Successfully" });
        }

        [HttpGet("Get")]
        public ActionResult GetAllRoomTypeAllocation()
        {
            return new JsonResult(new
            {
                success = true,
                data = _RoomTypeAllocationService.GetAll(),
                message = "Retrieved successfully"
            });
        }

        [HttpPost("Delete/{Id}")]
        public IActionResult Delete([FromForm] RoomTypeAllocationRequestDTO request)
        {
            return new JsonResult(new
            {
                success = true,
                data = _RoomTypeAllocationService.RemoveRoomTypeAllocation(request.Id),
                message = "Deleted successfully"
            });
        }
    }
}
