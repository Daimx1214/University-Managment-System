using UniversityManagementSystem.Model;

namespace UniversityManagmentSystem.Model
{
    public class StructureDesignation : BaseModel
    {
        public int StructureUnitId { get; set; }
        public int DesignationId { get; set; }
        public StructureUnit StructureUnit { get; set; }
        public Designation Designation { get; set; }
    }
}
