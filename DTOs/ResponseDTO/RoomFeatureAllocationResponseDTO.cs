using UniversityManagmentSystem.DTOs.ResponseDTP;

namespace UniversityManagmentSystem.DTOs.ResponseDTO
{
    public class RoomFeatureAllocationResponseDTO : BaseResponseDTO
    {
        public int RoomId { get; set; }
        public int RoomFeatureId { get; set; }
        public int Quantity { get; set; }
    }
}
