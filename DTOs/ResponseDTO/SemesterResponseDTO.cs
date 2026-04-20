using UniversityManagmentSystem.DTOs.ResponseDTP;

namespace UniversityManagmentSystem.DTOs.ResponseDTO
{
    public class SemesterResponseDTO : BaseResponseDTO
    {
        public string SemesterName { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
    }
}
