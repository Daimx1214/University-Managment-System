using UniversityManagmentSystem.DTOs.ResponseDTP;

namespace UniversityManagmentSystem.DTOs.ResponseDTO
{
    public class DepartmentResponseDTO : BaseResponseDTO
    {
        public string DepartmentName { get; set; }
        public string Description { get; set; }
        public DateTime EstablishedIn { get; set; }
        public string Code { get; set; }
        public int InstituteId { get; set; }
    }
}
