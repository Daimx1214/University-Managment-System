using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Model;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{
    public class ProgramSessionController : BaseController
    {
        private readonly ProgramSessionServices _ProgramSessionService;

        public ProgramSessionController(ProgramSessionServices ProgramSessionService)
        {
            _ProgramSessionService = ProgramSessionService;
        }

        [HttpPost("Post")]
        public ActionResult Post([FromForm] ProgramSessionRequestDTO request)
        {
            return new JsonResult(new { success = true, data = _ProgramSessionService.AddProgramSession(request), message = "Created Successfully" });
        }
        [HttpGet("Get")]
        public ActionResult GetAllProgramSession()
        {
            return new JsonResult(new
            {
                success = true,
                data = _ProgramSessionService.GetAll(),
                message = "Retrieved successfully"
            });
        }
        [HttpPost("Delete/{Id}")]
        public IActionResult Delete([FromForm] ProgramSessionRequestDTO request)
        {
            return new JsonResult(new
            {
                success = true,
                data = _ProgramSessionService.RemoveProgramSession(request.Id),
                message = "Deleted successfully"
            });
        }
    }
}