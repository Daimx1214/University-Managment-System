using UniversityManagmentSystem.DTOs.ResponseDTP;

namespace UniversityManagmentSystem.DTOs.ResponseDTO
{
    public class InstituteResponseDTO : BaseResponseDTO
    {
        public string InstituteName { get; set; }
        public string Description { get; set; }
        public DateTime EstablishedIn { get; set; }
        public string Code { get; set; }
        public int FacultyCampusId { get; set; }
    }
}
