using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{
    public class PLOController : BaseController
    {
        private readonly PLOServices _PLOService;

        public PLOController(PLOServices PLOService)
        {
            _PLOService = PLOService;
        }

        [HttpPost("Post")]
        public ActionResult Post([FromForm] PLORequestDTO request)
        {
            return new JsonResult(new { success = true, data = _PLOService.AddPLO(request), message = "Created Successfully" });
        }

        [HttpGet("Get")]
        public ActionResult GetAllPLO()
        {
            return new JsonResult(new
            {
                success = true,
                data = _PLOService.GetAll(),
                message = "Retrieved successfully"
            });
        }

        [HttpPost("Delete/{Id}")]
        public IActionResult Delete([FromForm] PLORequestDTO request)
        {
            return new JsonResult(new
            {
                success = true,
                data = _PLOService.RemovePLO(request.Id),
                message = "Deleted successfully"
            });
        }
    }
}
