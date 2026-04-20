using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{
    public class PEOToPLOController : BaseController
    {
        private readonly PEOToPLOServices _PEOToPLOService;

        public PEOToPLOController(PEOToPLOServices PEOToPLOService)
        {
            _PEOToPLOService = PEOToPLOService;
        }

        [HttpPost("Post")]
        public ActionResult Post([FromForm] PEOToPLORequestDTO request)
        {
            return new JsonResult(new { success = true, data = _PEOToPLOService.AddPEOToPLO(request), message = "Created Successfully" });
        }

        [HttpGet("Get")]
        public ActionResult GetAllPEOToPLO()
        {
            return new JsonResult(new
            {
                success = true,
                data = _PEOToPLOService.GetAll(),
                message = "Retrieved successfully"
            });
        }

        [HttpPost("Delete/{Id}")]
        public IActionResult Delete([FromForm] PEOToPLORequestDTO request)
        {
            return new JsonResult(new
            {
                success = true,
                data = _PEOToPLOService.RemovePEOToPLO(request.Id),
                message = "Deleted successfully"
            });
        }
    }
}
