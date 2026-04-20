using UniversityManagementSystem.Model;

namespace UniversityManagmentSystem.Model
{
    public class ProgramSession : BaseModel
    {
        public string SessionName { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public List<CourseScheme> CourseScheme { get; set; }
    }
}
