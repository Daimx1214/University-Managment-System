using UniversityManagmentSystem.DTOs.ResponseDTP;

namespace UniversityManagmentSystem.DTOs.ResponseDTO
{
    public class BuildingResponseDTO : BaseResponseDTO
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime EstablishedIn { get; set; }
        public string? Address { get; set; }
        public int CampusId { get; set; }
    }
}
