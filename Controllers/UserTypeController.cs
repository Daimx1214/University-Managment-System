using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{
    public class UserTypeController : BaseController
    {
        private readonly UserTypeServices _UserTypeService;

        public UserTypeController(UserTypeServices UserTypeService)
        {
            _UserTypeService = UserTypeService;
        }

        [HttpPost("Post")]
        public ActionResult Post([FromForm] UserTypeRequestDTO request)
        {
            return new JsonResult(new { success = true, data = _UserTypeService.AddUserType(request), message = "Created Successfully" });
        }

        [HttpGet("Get")]
        public ActionResult GetAllUserType()
        {
            return new JsonResult(new
            {
                success = true,
                data = _UserTypeService.GetAll(),
                message = "Retrieved successfully"
            });
        }

        [HttpPost("Delete/{Id}")]
        public IActionResult Delete([FromForm] UserTypeRequestDTO request)
        {
            return new JsonResult(new
            {
                success = true,
                data = _UserTypeService.RemoveUserType(request.Id),
                message = "Deleted successfully"
            });
        }
    }
}
