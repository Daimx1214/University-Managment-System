using UniversityManagementSystem.Model;

namespace UniversityManagmentSystem.Model
{
    public class Designation : BaseModel
    {
        public string  DesignationName { get; set; }
        public string Description { get; set; }
        public string  Code { get; set; }
        public List<StructureDesignation> StructureDesignations { get; set; }
    }
}
