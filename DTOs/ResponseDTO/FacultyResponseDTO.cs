using UniversityManagmentSystem.DTOs.ResponseDTP;

namespace UniversityManagmentSystem.DTOs.ResponseDTO
{
    public class FacultyResponseDTO : BaseResponseDTO
    {
        public string FacultyName { get; set; }
        public string Occupation { get; set; }
        public string Code { get; set; }
        public DateTime EstablishedIn { get; set; }
    }
}
