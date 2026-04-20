using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{
    public class InstituteController : BaseController
    {
        private readonly InstituteServices _InstituteService;

        public InstituteController(InstituteServices InstituteService)
        {
            _InstituteService = InstituteService;
        }

        [HttpPost("Post")]
        public ActionResult Post([FromForm] InstituteRequestDTO request)
        {
            return new JsonResult(new { success = true, data = _InstituteService.AddInstitute(request), message = "Created Successfully" });
        }

        [HttpGet("Get")]
        public ActionResult GetAllInstitute()
        {
            return new JsonResult(new
            {
                success = true,
                data = _InstituteService.GetAll(),
                message = "Retrieved successfully"
            });
        }

        [HttpPost("Delete/{Id}")]
        public IActionResult Delete([FromForm] InstituteRequestDTO request)
        {
            return new JsonResult(new
            {
                success = true,
                data = _InstituteService.RemoveInstitute(request.Id),
                message = "Deleted successfully"
            });
        }
    }
}
