using UniversityManagmentSystem.DTOs.ResponseDTP;

namespace UniversityManagmentSystem.DTOs.ResponseDTO
{
    public class DegreeProgramResponseDTO : BaseResponseDTO
    {
        public string DegreeProgramName { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public int DegreeLevelId { get; set; }
        public int DepartmentId { get; set; }
    }
}
