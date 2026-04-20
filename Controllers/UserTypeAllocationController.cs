using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{
    public class UserTypeAllocationController : BaseController
    {
        private readonly UserTypeAllocationServices _UserTypeAllocationService;

        public UserTypeAllocationController(UserTypeAllocationServices UserTypeAllocationService)
        {
            _UserTypeAllocationService = UserTypeAllocationService;
        }

        [HttpPost("Post")]
        public ActionResult Post([FromForm] UserTypeAllocationRequestDTO request)
        {
            return new JsonResult(new { success = true, data = _UserTypeAllocationService.AddUserTypeAllocation(request), message = "Created Successfully" });
        }

        [HttpGet("Get")]
        public ActionResult GetAllUserTypeAllocation()
        {
            return new JsonResult(new
            {
                success = true,
                data = _UserTypeAllocationService.GetAll(),
                message = "Retrieved successfully"
            });
        }

        [HttpPost("Delete/{Id}")]
        public IActionResult Delete([FromForm] UserTypeAllocationRequestDTO request)
        {
            return new JsonResult(new
            {
                success = true,
                data = _UserTypeAllocationService.RemoveUserTypeAllocation(request.Id),
                message = "Deleted successfully"
            });
        }
    }
}
