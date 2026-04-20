using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{
    public class UserInfoController : BaseController
    {
        private readonly UserInfoServices _UserInfoService;

        public UserInfoController(UserInfoServices UserInfoService)
        {
            _UserInfoService = UserInfoService;
        }

        [HttpPost("Post")]
        public ActionResult Post([FromForm] UserInfoRequestDTO request)
        {
            return new JsonResult(new { success = true, data = _UserInfoService.AddUserInfo(request), message = "Created Successfully" });
        }

        [HttpGet("Get")]
        public ActionResult GetAllUserInfo()
        {
            return new JsonResult(new
            {
                success = true,
                data = _UserInfoService.GetAll(),
                message = "Retrieved successfully"
            });
        }

        [HttpPost("Delete/{Id}")]
        public IActionResult Delete([FromForm] UserInfoRequestDTO request)
        {
            return new JsonResult(new
            {
                success = true,
                data = _UserInfoService.RemoveUserInfo(request.Id),
                message = "Deleted successfully"
            });
        }
    }
}
