using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{
    public class StructureUnitController : BaseController
    {
        private readonly StructureUnitServices _StructureUnitService;

        public StructureUnitController(StructureUnitServices StructureUnitService)
        {
            _StructureUnitService = StructureUnitService;
        }

        [HttpPost("Post")]
        public ActionResult Post([FromForm] StructureUnitRequestDTO request)
        {
            return new JsonResult(new { success = true, data = _StructureUnitService.AddStructureUnit(request), message = "Created Successfully" });
        }

        [HttpGet("Get")]
        public ActionResult GetAllStructureUnit()
        {
            return new JsonResult(new
            {
                success = true,
                data = _StructureUnitService.GetAll(),
                message = "Retrieved successfully"
            });
        }

        [HttpPost("Delete/{Id}")]
        public IActionResult Delete([FromForm] StructureUnitRequestDTO request)
        {
            return new JsonResult(new
            {
                success = true,
                data = _StructureUnitService.RemoveStructureUnit(request.Id),
                message = "Deleted successfully"
            });
        }
    }
}
