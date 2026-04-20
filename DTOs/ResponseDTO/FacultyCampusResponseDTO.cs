using UniversityManagmentSystem.DTOs.ResponseDTP;

namespace UniversityManagmentSystem.DTOs.ResponseDTO
{
    public class FacultyCampusResponseDTO : BaseResponseDTO
    {
        public int FacultyId { get; set; }
        public int CampusId { get; set; }
    }
}
