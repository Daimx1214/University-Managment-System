using UniversityManagmentSystem.DTOs.ResponseDTP;

namespace UniversityManagmentSystem.DTOs.ResponseDTO
{
    public class ProgramSessionResponseDTO : BaseResponseDTO
    {
        public string ProgramSessionName { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
    }
}
