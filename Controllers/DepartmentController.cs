using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{
    public class DepartmentController : BaseController
    {
        private readonly DepartmentServices _DepartmentService;

        public DepartmentController(DepartmentServices DepartmentService)
        {
            _DepartmentService = DepartmentService;
        }

        [HttpPost("Post")]
        public ActionResult Post([FromForm] DepartmentRequestDTO request)
        {
            return new JsonResult(new { success = true, data = _DepartmentService.AddDepartment(request), message = "Created Successfully" });
        }

        [HttpGet("Get")]
        public ActionResult GetAllDepartment()
        {
            return new JsonResult(new
            {
                success = true,
                data = _DepartmentService.GetAll(),
                message = "Retrieved successfully"
            });
        }

        [HttpPost("Delete/{Id}")]
        public IActionResult Delete([FromForm] DepartmentRequestDTO request)
        {
            return new JsonResult(new
            {
                success = true,
                data = _DepartmentService.RemoveDepartment(request.Id),
                message = "Deleted successfully"
            });
        }
    }
}
