using UniversityManagmentSystem.DTOs.ResponseDTP;

namespace UniversityManagmentSystem.DTOs.ResponseDTO
{
    public class CLOResponseDTO : BaseResponseDTO
    {
        public string Description { get; set; }
        public string Code { get; set; }
        public int LearningTypeId { get; set; }
        public int LearningLevelId { get; set; }
    }
}
