using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{
    public class PLOToCLOController : BaseController
    {
        private readonly PLOToCLOServices _PLOToCLOService;

        public PLOToCLOController(PLOToCLOServices PLOToCLOService)
        {
            _PLOToCLOService = PLOToCLOService;
        }

        [HttpPost("Post")]
        public ActionResult Post([FromForm] PLOToCLORequestDTO request)
        {
            return new JsonResult(new { success = true, data = _PLOToCLOService.AddPLOToCLO(request), message = "Created Successfully" });
        }

        [HttpGet("Get")]
        public ActionResult GetAllPLOToCLO()
        {
            return new JsonResult(new
            {
                success = true,
                data = _PLOToCLOService.GetAll(),
                message = "Retrieved successfully"
            });
        }

        [HttpPost("Delete/{Id}")]
        public IActionResult Delete([FromForm] PLOToCLORequestDTO request)
        {
            return new JsonResult(new
            {
                success = true,
                data = _PLOToCLOService.RemovePLOToCLO(request.Id),
                message = "Deleted successfully"
            });
        }
    }
}
