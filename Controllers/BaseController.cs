using Microsoft.AspNetCore.Mvc;

namespace UniversityManagmentSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // Optional here; usually route goes in child controller
    public class BaseController : ControllerBase
    {
        // You can add shared methods or properties for all controllers here
    }
}
