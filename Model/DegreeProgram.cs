using UniversityManagementSystem.Model;

namespace UniversityManagmentSystem.Model
{
    public class DegreeProgram : BaseModel
    {
        public string DegreeProgramName { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public int DegreeLevelId { get; set; }
        public int DepartmentId { get; set; }
        DegreeLevel DegreeLevel { get; set; }
        Department Department { get; set; }
        public List<CourseScheme> CourseScheme { get; set; }
        public List<PEO> PEOs { get; set; }
        public List<PLO> PLOs { get; set; }

    }
}
