using UniversityManagementSystem.Model;

namespace UniversityManagmentSystem.Model
{
    public class StructureType : BaseModel
    {
        public string StructureTypeName { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public List<StructureUnit> StructureUnits { get; set; }
    }
}
