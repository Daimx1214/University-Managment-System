using UniversityManagmentSystem.DTOs.ResponseDTP;

namespace UniversityManagmentSystem.DTOs.ResponseDTO
{
    public class StructureUnitResponseDTO : BaseResponseDTO
    {
        public string StructureUnitName { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public int StructureTypeId { get; set; }
    }
}
