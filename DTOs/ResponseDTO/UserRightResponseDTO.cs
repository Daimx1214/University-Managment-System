using UniversityManagmentSystem.DTOs.ResponseDTP;

namespace UniversityManagmentSystem.DTOs.ResponseDTO
{
    public class UserRightResponseDTO : BaseResponseDTO
    {
        public string RightCode { get; set; }
        public string UserRightName { get; set; }
        public string URL { get; set; }
        public string TabName { get; set; }
    }
}
