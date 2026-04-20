using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{
    public class UserRightAllocationController : BaseController
    {
        private readonly UserRightAllocationServices _UserRightAllocationService;

        public UserRightAllocationController(UserRightAllocationServices UserRightAllocationService)
        {
            _UserRightAllocationService = UserRightAllocationService;
        }

        [HttpPost("Post")]
        public ActionResult Post([FromForm] UserRightAllocationRequestDTO request)
        {
            return new JsonResult(new { success = true, data = _UserRightAllocationService.AddUserRightAllocation(request), message = "Created Successfully" });
        }

        [HttpGet("Get")]
        public ActionResult GetAllUserRightAllocation()
        {
            return new JsonResult(new
            {
                success = true,
                data = _UserRightAllocationService.GetAll(),
                message = "Retrieved successfully"
            });
        }

        [HttpPost("Delete/{Id}")]
        public IActionResult Delete([FromForm] UserRightAllocationRequestDTO request)
        {
            return new JsonResult(new
            {
                success = true,
                data = _UserRightAllocationService.RemoveUserRightAllocation(request.Id),
                message = "Deleted successfully"
            });
        }
    }
}
