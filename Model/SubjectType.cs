using UniversityManagementSystem.Model;

namespace UniversityManagmentSystem.Model
{
    public class SubjectType : BaseModel
    {
        public string SubjectTypeName { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public List<CourseScheme> CourseScheme { get; set; }
    }
}
