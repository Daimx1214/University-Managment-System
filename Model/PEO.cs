using UniversityManagementSystem.Model;

namespace UniversityManagmentSystem.Model
{
    public class PEO : BaseModel
    {
        public string Description { get; set; }
        public string Code { get; set; }
        public int DegreeProgramId { get; set; }
        DegreeProgram degreeProgram { get; set; }
        public List<PEOToPLO> PEOToPLOs { get; set; }
    }
}
