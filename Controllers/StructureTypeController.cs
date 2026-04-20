using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Model;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{
    public class StructureTypeController : BaseController
    {
        private readonly StructureTypeServices _StructureTypeService;

        public StructureTypeController(StructureTypeServices StructureTypeService)
        {
            _StructureTypeService = StructureTypeService;
        }

        [HttpPost("Post")]
        public ActionResult Post([FromForm] StructureTypeRequestDTO request)
        {
            return new JsonResult(new { success = true, data = _StructureTypeService.AddStructureType(request), message = "Created Successfully" });
        }
        [HttpGet("Get")]
        public ActionResult GetAllStructureType()
        {
            return new JsonResult(new
            {
                success = true,
                data = _StructureTypeService.GetAll(),
                message = "Retrieved successfully"
            });
        }
        [HttpPost("Delete/{Id}")]
        public IActionResult Delete([FromForm] StructureTypeRequestDTO request)
        {
            return new JsonResult(new
            {
                success = true,
                data = _StructureTypeService.RemoveStructureType(request.Id),
                message = "Deleted successfully"
            });
        }
    }
}