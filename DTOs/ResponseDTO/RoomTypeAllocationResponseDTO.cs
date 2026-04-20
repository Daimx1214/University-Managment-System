using UniversityManagmentSystem.DTOs.ResponseDTP;

namespace UniversityManagmentSystem.DTOs.ResponseDTO
{
    public class RoomTypeAllocationResponseDTO : BaseResponseDTO
    {
        public int RoomId { get; set; }
        public int RoomTypeId { get; set; }
    }
}
