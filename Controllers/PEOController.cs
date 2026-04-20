using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{
    public class PEOController : BaseController
    {
        private readonly PEOServices _PEOService;

        public PEOController(PEOServices PEOService)
        {
            _PEOService = PEOService;
        }

        [HttpPost("Post")]
        public ActionResult Post([FromForm] PEORequestDTO request)
        {
            return new JsonResult(new { success = true, data = _PEOService.AddPEO(request), message = "Created Successfully" });
        }

        [HttpGet("Get")]
        public ActionResult GetAllPEO()
        {
            return new JsonResult(new
            {
                success = true,
                data = _PEOService.GetAll(),
                message = "Retrieved successfully"
            });
        }

        [HttpPost("Delete/{Id}")]
        public IActionResult Delete([FromForm] PEORequestDTO request)
        {
            return new JsonResult(new
            {
                success = true,
                data = _PEOService.RemovePEO(request.Id),
                message = "Deleted successfully"
            });
        }
    }
}
