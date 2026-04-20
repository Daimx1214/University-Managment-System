using UniversityManagmentSystem.DTOs.ResponseDTP;

namespace UniversityManagmentSystem.DTOs.ResponseDTO
{
    public class SubjectTypeResponseDTO : BaseResponseDTO
    {
        public string SubjectTypeName { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
    }
}
