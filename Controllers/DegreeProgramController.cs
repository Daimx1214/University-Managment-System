using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{
    public class DegreeProgramController : BaseController
    {
        private readonly DegreeProgramServices _DegreeProgramService;

        public DegreeProgramController(DegreeProgramServices DegreeProgramService)
        {
            _DegreeProgramService = DegreeProgramService;
        }

        [HttpPost("Post")]
        public ActionResult Post([FromForm] DegreeProgramRequestDTO request)
        {
            return new JsonResult(new { success = true, data = _DegreeProgramService.AddDegreeProgram(request), message = "Created Successfully" });
        }

        [HttpGet("Get")]
        public ActionResult GetAllDegreeProgram()
        {
            return new JsonResult(new
            {
                success = true,
                data = _DegreeProgramService.GetAll(),
                message = "Retrieved successfully"
            });
        }

        [HttpPost("Delete/{Id}")]
        public IActionResult Delete([FromForm] DegreeProgramRequestDTO request)
        {
            return new JsonResult(new
            {
                success = true,
                data = _DegreeProgramService.RemoveDegreeProgram(request.Id),
                message = "Deleted successfully"
            });
        }
    }
}
