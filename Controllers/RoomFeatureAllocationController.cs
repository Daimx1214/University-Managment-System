using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{
    public class RoomFeatureAllocationController : BaseController
    {
        private readonly RoomFeatureAllocationServices _RoomFeatureAllocationService;

        public RoomFeatureAllocationController(RoomFeatureAllocationServices RoomFeatureAllocationService)
        {
            _RoomFeatureAllocationService = RoomFeatureAllocationService;
        }

        [HttpPost("Post")]
        public ActionResult Post([FromForm] RoomFeatureAllocationRequestDTO request)
        {
            return new JsonResult(new { success = true, data = _RoomFeatureAllocationService.AddRoomFeatureAllocation(request), message = "Created Successfully" });
        }

        [HttpGet("Get")]
        public ActionResult GetAllRoomFeatureAllocation()
        {
            return new JsonResult(new
            {
                success = true,
                data = _RoomFeatureAllocationService.GetAll(),
                message = "Retrieved successfully"
            });
        }

        [HttpPost("Delete/{Id}")]
        public IActionResult Delete([FromForm] RoomFeatureAllocationRequestDTO request)
        {
            return new JsonResult(new
            {
                success = true,
                data = _RoomFeatureAllocationService.RemoveRoomFeatureAllocation(request.Id),
                message = "Deleted successfully"
            });
        }
    }
}
