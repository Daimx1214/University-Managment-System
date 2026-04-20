using Microsoft.AspNetCore.Mvc;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Model;
using UniversityManagmentSystem.Services;

namespace UniversityManagmentSystem.Controllers
{
    public class RoomFeatureController : BaseController
    {
        private readonly RoomFeatureServices _RoomFeatureService;

        public RoomFeatureController(RoomFeatureServices RoomFeatureService)
        {
            _RoomFeatureService = RoomFeatureService;
        }

        [HttpPost("Post")]
        public ActionResult Post([FromForm] RoomFeatureRequestDTO request)
        {
            return new JsonResult(new 
            {
                success = true,
                data = _RoomFeatureService.AddRoomFeature(request),
                message = "Created Successfully"
            });
        }
        [HttpGet("Get")]
        public ActionResult GetAllRoomFeature()
        {
            return new JsonResult(new
            {
                success = true,
                data = _RoomFeatureService.GetAll(),
                message = "Retrieved successfully"
            });
        }
        [HttpPost("Delete/{Id}")]
        public IActionResult Delete([FromForm] RoomFeatureRequestDTO request)
        {
            return new JsonResult(new
            {
                success = true,
                data = _RoomFeatureService.RemoveRoomFeature(request.Id),
                message = "Deleted successfully"
            });
        }
    }
}