using UniversityManagmentSystem.DTOs.ResponseDTP;

namespace UniversityManagmentSystem.DTOs.ResponseDTO
{
    public class UserInfoResponseDTO : BaseResponseDTO
    {
        public string UiUser { get; set; }
        public string UiPass { get; set; }
        public string UserName { get; set; }
    }
}
