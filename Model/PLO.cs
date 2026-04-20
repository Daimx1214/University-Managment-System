using UniversityManagementSystem.Model;

namespace UniversityManagmentSystem.Model
{
    public class PLO : BaseModel
    {
        public string Description { get; set; }
        public string code { get; set; }
        public int DegreeProgramId { get; set; }
        public DegreeProgram DegreeProgram { get; set; }
        public List<PLOToCLO> PLOToCLOs { get; set; }
    }
}
