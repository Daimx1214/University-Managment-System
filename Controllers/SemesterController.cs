using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Model;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{
    public class SemesterController : BaseController
    {
        private readonly SemesterServices _SemesterService;

        public SemesterController(SemesterServices SemesterService)
        {
            _SemesterService = SemesterService;
        }

        [HttpPost("Post")]
        public ActionResult Post([FromForm] SemesterRequestDTO request)
        {
            return new JsonResult(new { success = true, data = _SemesterService.AddSemester(request), message = "Created Successfully" });
        }
        [HttpGet("Get")]
        public ActionResult GetAllSemester()
        {
            return new JsonResult(new
            {
                success = true,
                data = _SemesterService.GetAll(),
                message = "Retrieved successfully"
            });
        }
        [HttpPost("Delete/{Id}")]
        public IActionResult Delete([FromForm] SemesterRequestDTO request)
        {
            return new JsonResult(new
            {
                success = true,
                data = _SemesterService.RemoveSemester(request.Id),
                message = "Deleted successfully"
            });
        }
    }
}