using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{
    public class UserRightController : BaseController
    {
        private readonly UserRightServices _UserRightService;

        public UserRightController(UserRightServices UserRightService)
        {
            _UserRightService = UserRightService;
        }

        [HttpPost("Post")]
        public ActionResult Post([FromForm] UserRightRequestDTO request)
        {
            return new JsonResult(new { success = true, data = _UserRightService.AddUserRight(request), message = "Created Successfully" });
        }

        [HttpGet("Get")]
        public ActionResult GetAllUserRight()
        {
            return new JsonResult(new
            {
                success = true,
                data = _UserRightService.GetAll(),
                message = "Retrieved successfully"
            });
        }

        [HttpPost("Delete/{Id}")]
        public IActionResult Delete([FromForm] UserRightRequestDTO request)
        {
            return new JsonResult(new
            {
                success = true,
                data = _UserRightService.RemoveUserRight(request.Id),
                message = "Deleted successfully"
            });
        }
    }
}
