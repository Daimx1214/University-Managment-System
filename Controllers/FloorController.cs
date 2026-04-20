using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{
    public class FloorController : BaseController
    {
        private readonly FloorServices _FloorService;

        public FloorController(FloorServices FloorService)
        {
            _FloorService = FloorService;
        }

        [HttpPost("Post")]
        public ActionResult Post([FromForm] FloorRequestDTO request)
        {
            return new JsonResult(new { success = true, data = _FloorService.AddFloor(request), message = "Created Successfully" });
        }

        [HttpGet("Get")]
        public ActionResult GetAllFloor()
        {
            return new JsonResult(new
            {
                success = true,
                data = _FloorService.GetAll(),
                message = "Retrieved successfully"
            });
        }

        [HttpPost("Delete/{Id}")]
        public IActionResult Delete([FromForm] FloorRequestDTO request)
        {
            return new JsonResult(new
            {
                success = true,
                data = _FloorService.RemoveFloor(request.Id),
                message = "Deleted successfully"
            });
        }
    }
}
