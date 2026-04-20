using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{
    public class CampusController : BaseController
    {
        private readonly CampusServices _CampusService;

        public CampusController(CampusServices CampusService)
        {
            _CampusService = CampusService;
        }

        [HttpPost("Post")]
        public ActionResult Post([FromForm] CampusRequestDTO request)
        {
            return new JsonResult(new { success = true, data = _CampusService.AddCampus(request), message = "Created Successfully" });
        }

        [HttpGet("Get")]
        public ActionResult GetAllCampus()
        {
            return new JsonResult(new
            {
                success = true,
                data = _CampusService.GetAll(),
                message = "Retrieved successfully"
            });
        }

        [HttpPost("Delete/{Id}")]
        public IActionResult Delete([FromForm] CampusRequestDTO request)
        {

            return new JsonResult(new
            {
                success = true,
                data = _CampusService.RemoveCampus(request.Id),
                message = "Deleted successfully"
            });
        }
    }
}
