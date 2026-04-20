using UniversityManagmentSystem.DTOs.ResponseDTP;

namespace UniversityManagmentSystem.DTOs.ResponseDTO
{
    public class CourseSchemeResponseDTO : BaseResponseDTO
    {
        public int SubjectId { get; set; }
        public int SubjectTypeId { get; set; }
        public int CreditHours { get; set; }
        public int DegreeProgramId { get; set; }
        public int ProgramSessionId { get; set; }
        public int SemesterId { get; set; }
    }
}
