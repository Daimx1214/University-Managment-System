using UniversityManagmentSystem.DTOs.ResponseDTP;

namespace UniversityManagmentSystem.DTOs.ResponseDTO
{
    public class PEOToPLOResponseDTO : BaseResponseDTO
    {
        public int Id { get; set; }
        public int Weightage { get; set; }
        public int PEOId { get; set; }
        public int PLOId { get; set; }
    }
}
