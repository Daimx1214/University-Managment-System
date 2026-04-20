using UniversityManagmentSystem.DTOs.ResponseDTP;

namespace UniversityManagmentSystem.DTOs.ResponseDTO
{
    public class SubjectResponseDTO : BaseResponseDTO
    {
        public string SubjectName { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
    }
}
