using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{
    public class BuildingController : BaseController
    {
        private readonly BuildingServices _BuildingService;

        public BuildingController(BuildingServices BuildingService)
        {
            _BuildingService = BuildingService;
        }

        [HttpPost("Post")]
        public ActionResult Post([FromForm] BuildingRequestDTO request)
        {
            return new JsonResult(new { success = true, data = _BuildingService.AddBuilding(request), message = "Created Successfully" });
        }

        [HttpGet("Get")]
        public ActionResult GetAllBuilding()
        {
            return new JsonResult(new
            {
                success = true,
                data = _BuildingService.GetAll(),
                message = "Retrieved successfully"
            });
        }

        [HttpPost("Delete/{Id}")]
        public IActionResult Delete([FromForm] BuildingRequestDTO request)
        {
            return new JsonResult(new
            {
                success = true,
                data = _BuildingService.RemoveBuilding(request.Id),
                message = "Deleted successfully"
            });
        }
    }
}
