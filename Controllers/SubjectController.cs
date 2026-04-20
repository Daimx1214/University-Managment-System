using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Model;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{
    public class SubjectController : BaseController
    {
        private readonly SubjectServices _SubjectService;

        public SubjectController(SubjectServices SubjectService)
        {
            _SubjectService = SubjectService;
        }

        [HttpPost("Post")]
        public ActionResult Post([FromForm] SubjectRequestDTO request)
        {
            return new JsonResult(new { success = true, data = _SubjectService.AddSubject(request), message = "Created Successfully" });
        }
        [HttpGet("Get")]
        public ActionResult GetAllSubject()
        {
            return new JsonResult(new
            {
                success = true,
                data = _SubjectService.GetAll(),
                message = "Retrieved successfully"
            });
        }
        [HttpPost("Delete/{Id}")]
        public IActionResult Delete([FromForm] SubjectRequestDTO request)
        {
            return new JsonResult(new
            {
                success = true,
                data = _SubjectService.RemoveSubject(request.Id),
                message = "Deleted successfully"
            });
        }
    }
}