using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{
    public class LearningTypeController : BaseController
    {
        private readonly LearningTypeServices _LearningTypeService;

        public LearningTypeController(LearningTypeServices LearningTypeService)
        {
            _LearningTypeService = LearningTypeService;
        }

        [HttpPost("Post")]
        public ActionResult Post([FromForm] LearningTypeRequestDTO request)
        {
            return new JsonResult(new { success = true, data = _LearningTypeService.AddLearningType(request), message = "Created Successfully" });
        }

        [HttpGet("Get")]
        public ActionResult GetAllLearningType()
        {
            return new JsonResult(new
            {
                success = true,
                data = _LearningTypeService.GetAll(),
                message = "Retrieved successfully"
            });
        }

        [HttpPost("Delete/{Id}")]
        public IActionResult Delete([FromForm] LearningTypeRequestDTO request)
        {
            return new JsonResult(new
            {
                success = true,
                data = _LearningTypeService.RemoveLearningType(request.Id),
                message = "Deleted successfully"
            });
        }
    }
}
