using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{
    public class DegreeLevelController : BaseController
    {
        private readonly DegreeLevelServices _degreeLevelService;

        public DegreeLevelController(DegreeLevelServices degreeLevelService)
        {
            _degreeLevelService = degreeLevelService;
        }

        [HttpPost("Post")]
        public ActionResult Post([FromForm] DegreeLevelRequestDTO request)
        {
            return new JsonResult(new { success = true, data = _degreeLevelService.AddDegreeLevel(request), message = "Created Successfully" });
        }
        [HttpGet("Get")]
        public ActionResult  GetAllDegreeLevel() 
        {
            return new JsonResult(new
            {
                success = true,
                data = _degreeLevelService.GetAll(),
                message = "Retrived successfully"
            });
        }
        [HttpPost("Delete/{Id}")]

        public IActionResult RemoveDegreeLevel([FromForm] DegreeLevelRequestDTO request)
        {
            return new JsonResult(new
            {
                success = true,
                data = _degreeLevelService.RemoveDegreeLevel(request.Id),
                message = "Deleted successfully"
            });
        }
    }
}