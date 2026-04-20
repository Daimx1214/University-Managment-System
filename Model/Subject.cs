using UniversityManagementSystem.Model;

namespace UniversityManagmentSystem.Model
{
    public class Subject : BaseModel
    {
        public string SubjectName { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public List<CourseScheme> CourseScheme { get; set; }
    }
}
