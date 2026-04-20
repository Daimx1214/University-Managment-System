using UniversityManagementSystem.Model;

namespace UniversityManagmentSystem.Model
{
    public class Semester : BaseModel
    {
        public string SemesterName { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public List<CourseScheme> CourseScheme { get; set; }
    }
}
