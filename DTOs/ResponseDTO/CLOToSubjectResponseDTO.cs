using UniversityManagmentSystem.DTOs.ResponseDTP;

namespace UniversityManagmentSystem.DTOs.ResponseDTO
{
    public class CLOToSubjectResponseDTO : BaseResponseDTO
    {
        public int CLOId { get; set; }
        public int CourseSchemeId { get; set; }
        public int ProgramSessionId { get; set; }
    }
}
