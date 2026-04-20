using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{
    public class FacultyCampusController : BaseController
    {
        private readonly FacultyCampusServices _FacultyCampusService;

        public FacultyCampusController(FacultyCampusServices FacultyCampusService)
        {
            _FacultyCampusService = FacultyCampusService;
        }

        [HttpPost("Post")]
        public ActionResult Post([FromForm] FacultyCampusRequestDTO request)
        {
            return new JsonResult(new { success = true, data = _FacultyCampusService.AddFacultyCampus(request), message = "Created Successfully" });
        }

        [HttpGet("Get")]
        public ActionResult GetAllFacultyCampus()
        {
            return new JsonResult(new
            {
                success = true,
                data = _FacultyCampusService.GetAll(),
                message = "Retrieved successfully"
            });
        }

        [HttpPost("Delete/{Id}")]
        public IActionResult Delete([FromForm] FacultyCampusRequestDTO request)
        {
            return new JsonResult(new
            {
                success = true,
                data = _FacultyCampusService.RemoveFacultyCampus(request.Id),
                message = "Deleted successfully"
            });
        }
    }
}
