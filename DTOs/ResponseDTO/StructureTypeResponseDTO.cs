using UniversityManagmentSystem.DTOs.ResponseDTP;

namespace UniversityManagmentSystem.DTOs.ResponseDTO
{
    public class StructureTypeResponseDTO : BaseResponseDTO
    {
        public string StructureTypeName { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
    }
}
