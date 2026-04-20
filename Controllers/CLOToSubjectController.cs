using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{
    public class CLOToSubjectController : BaseController
    {
        private readonly CLOToSubjectServices _CLOToSubjectService;

        public CLOToSubjectController(CLOToSubjectServices CLOToSubjectService)
        {
            _CLOToSubjectService = CLOToSubjectService;
        }

        [HttpPost("Post")]
        public ActionResult Post([FromForm] CLOToSubjectRequestDTO request)
        {
            return new JsonResult(new { success = true, data = _CLOToSubjectService.AddCLOToSubject(request), message = "Created Successfully" });
        }

        [HttpGet("Get")]
        public ActionResult GetAllCLOToSubject()
        {
            return new JsonResult(new
            {
                success = true,
                data = _CLOToSubjectService.GetAll(),
                message = "Retrieved successfully"
            });
        }

        [HttpPost("Delete/{Id}")]
        public IActionResult Delete([FromForm] CLOToSubjectRequestDTO request)
        {
            return new JsonResult(new
            {
                success = true,
                data = _CLOToSubjectService.RemoveCLOToSubject(request.Id),
                message = "Deleted successfully"
            });
        }
    }
}
