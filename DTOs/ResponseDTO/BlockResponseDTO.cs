using UniversityManagmentSystem.DTOs.ResponseDTP;

namespace UniversityManagmentSystem.DTOs.ResponseDTO
{
    public class BlockResponseDTO : BaseResponseDTO
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateTime EstablishedIn { get; set; }
        public int Code { get; set; }
    }
}
