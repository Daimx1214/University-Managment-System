using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Model;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{
    public class SubjectTypeController : BaseController
    {
        private readonly SubjectTypeServices _SubjectTypeService;

        public SubjectTypeController(SubjectTypeServices SubjectTypeService)
        {
            _SubjectTypeService = SubjectTypeService;
        }

        [HttpPost("Post")]
        public ActionResult Post([FromForm] SubjectTypeRequestDTO request)
        {
            return new JsonResult(new { success = true, data = _SubjectTypeService.AddSubjectType(request), message = "Created Successfully" });
        }
        [HttpGet("Get")]
        public ActionResult GetAllSubjectType()
        {
            return new JsonResult(new
            {
                success = true,
                data = _SubjectTypeService.GetAll(),
                message = "Retrieved successfully"
            });
        }
        [HttpPost("Delete/{Id}")]
        public IActionResult Delete([FromForm] SubjectTypeRequestDTO request)
        {
            return new JsonResult(new
            {
                success = true,
                data = _SubjectTypeService.RemoveSubjectType(request.Id),
                message = "Deleted successfully"
            });
        }
    }
}