using UniversityManagmentSystem.DTOs.ResponseDTP;

namespace UniversityManagmentSystem.DTOs.ResponseDTO
{
    public class DesignationResponseDTO : BaseResponseDTO
    {
        public string DesignationName { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
    }
}
