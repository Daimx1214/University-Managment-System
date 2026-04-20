using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.DTOs.RequestDTO;

namespace UniversityManagmentSystem.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UniversityController : BaseController
    {
        private readonly UniversityServices _universityServices;

        public UniversityController(UniversityServices universityServices)
        {
            _universityServices = universityServices;
        }

        [HttpGet]
        public ActionResult GetAllUniversities()
        {
            return new JsonResult(new
            {
                success = true,
                data = _universityServices.GetAll(),
                message = "Fetched successfully"
            });
        }

        [HttpPost]
        public ActionResult Post([FromForm] UniversityRequestDTO request)
        {
            return new JsonResult(new
            {
                success = true,
                data = _universityServices.AddUniversity(request),
                message = "Created successfully"
            });
        }

        [HttpPost("Delete")]
        public IActionResult Delete([FromBody] UniversityRequestDTO request)
        {
            return new JsonResult(new
            {
                success = true,
                data = _universityServices.RemoveUniversity(request.Id),
                message = "Deleted successfully"
            });
        }
    }
}
