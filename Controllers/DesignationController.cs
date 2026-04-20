using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{
    public class DesignationController : BaseController
    {
        private readonly DesignationServices _designationService;

        public DesignationController(DesignationServices designationService)
        {
            _designationService = designationService;
        }

        [HttpPost("Post")]
        public ActionResult Post([FromForm] DesignationRequestDTO request)
        {
            return new JsonResult(new { success = true, data = _designationService.AddDesignation(request), message = "Created Successfully" });
        }
        [HttpGet("Get")]
        public ActionResult GetAllDesignation()
        {
            return new JsonResult(new
            {
                success = true,
                data = _designationService.GetAll(),
                message = "Retrieved successfully"
            });
        }
        [HttpPost("Delete/{Id}")]
        public IActionResult Delete([FromForm] DesignationRequestDTO request)
        {
            return new JsonResult(new
            {
                success = true,
                data = _designationService.RemoveDesignation(request.Id),
                message = "Deleted successfully"
            });
        }
    }
}