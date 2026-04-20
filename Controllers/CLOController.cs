using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{
    public class CLOController : BaseController
    {
        private readonly CLOServices _CLOService;

        public CLOController(CLOServices CLOService)
        {
            _CLOService = CLOService;
        }

        [HttpPost("Post")]
        public ActionResult Post([FromForm] CLORequestDTO request)
        {
            return new JsonResult(new { success = true, data = _CLOService.AddCLO(request), message = "Created Successfully" });
        }

        [HttpGet("Get")]
        public ActionResult GetAllCLO()
        {
            return new JsonResult(new
            {
                success = true,
                data = _CLOService.GetAll(),
                message = "Retrieved successfully"
            });
        }

        [HttpPost("Delete/{Id}")]
        public IActionResult Delete([FromForm] CLORequestDTO request)
        {
            return new JsonResult(new
            {
                success = true,
                data = _CLOService.RemoveCLO(request.Id),
                message = "Deleted successfully"
            });
        }
    }
}
