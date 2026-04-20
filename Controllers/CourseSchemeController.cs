using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{
    public class CourseSchemeController : BaseController
    {
        private readonly CourseSchemeServices _CourseSchemeService;

        public CourseSchemeController(CourseSchemeServices CourseSchemeService)
        {
            _CourseSchemeService = CourseSchemeService;
        }

        [HttpPost("Post")]
        public ActionResult Post([FromForm] CourseSchemeRequestDTO request)
        {
            return new JsonResult(new { success = true, data = _CourseSchemeService.AddCourseScheme(request), message = "Created Successfully" });
        }

        [HttpGet("Get")]
        public ActionResult GetAllCourseScheme()
        {
            return new JsonResult(new
            {
                success = true,
                data = _CourseSchemeService.GetAll(),
                message = "Retrieved successfully"
            });
        }

        [HttpPost("Delete/{Id}")]
        public IActionResult Delete([FromForm] CourseSchemeRequestDTO request)
        {
            return new JsonResult(new
            {
                success = true,
                data = _CourseSchemeService.RemoveCourseScheme(request.Id),
                message = "Deleted successfully"
            });
        }
    }
}
