using UniversityManagmentSystem.DTOs.ResponseDTP;
using UniversityManagmentSystem.Interfaces;

namespace UniversityManagmentSystem.DTOs.ResponseDTO
{
    public class UserRightAllocationResponseDTO : BaseResponseDTO
    {
        public int UserRightID { get; set; }
        public int UserTypeId { get; set; }
    }
}
