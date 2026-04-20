using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{
    public class StructureDesignationController : BaseController
    {
        private readonly StructureDesignationServices _StructureDesignationService;

        public StructureDesignationController(StructureDesignationServices StructureDesignationService)
        {
            _StructureDesignationService = StructureDesignationService;
        }

        [HttpPost("Post")]
        public ActionResult Post([FromForm] StructureDesignationRequestDTO request)
        {
            return new JsonResult(new { success = true, data = _StructureDesignationService.AddStructureDesignation(request), message = "Created Successfully" });
        }

        [HttpGet("Get")]
        public ActionResult GetAllStructureDesignation()
        {
            return new JsonResult(new
            {
                success = true,
                data = _StructureDesignationService.GetAll(),
                message = "Retrieved successfully"
            });
        }

        [HttpPost("Delete/{Id}")]
        public IActionResult Delete([FromForm] StructureDesignationRequestDTO request)
        {
            return new JsonResult(new
            {
                success = true,
                data = _StructureDesignationService.RemoveStructureDesignation(request.Id),
                message = "Deleted successfully"
            });
        }
    }
}
