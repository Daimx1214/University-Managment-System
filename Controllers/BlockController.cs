using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{
    public class BlockController : BaseController
    {
        private readonly BlockServices _BlockService;

        public BlockController(BlockServices BlockService)
        {
            _BlockService = BlockService;
        }

        [HttpPost("Post")]
        public ActionResult Post([FromForm] BlockRequestDTO request)
        {
            return new JsonResult(new { success = true, data = _BlockService.AddBlock(request), message = "Created Successfully" });
        }

        [HttpGet("Get")]
        public ActionResult GetAllBlock()
        {
            return new JsonResult(new
            {
                success = true,
                data = _BlockService.GetAll(),
                message = "Retrieved successfully"
            });
        }
        [HttpPost("Delete")]
        public IActionResult Delete([FromForm] BlockRequestDTO request)
        {
            return new JsonResult(new
            {
                success = true,
                data = _BlockService.RemoveBlock(request.Id),
                message = "Deleted successfully"
            });
        }

    }
}
