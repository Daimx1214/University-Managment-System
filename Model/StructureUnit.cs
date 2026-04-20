using UniversityManagementSystem.Model;

namespace UniversityManagmentSystem.Model
{
    public class StructureUnit : BaseModel
    {
        public string StructureUnitName { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public int StructureTypeId { get; set; }
        public StructureType StructureType { get; set; }
        public List <StructureDesignation> StructureDesignations { get; set; }
    }
}
