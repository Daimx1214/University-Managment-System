using UniversityManagementSystem.Model;

namespace UniversityManagmentSystem.Model
{
    public class CLO : BaseModel
    {
        public string Description { get; set; }
        public string Code { get; set; }
        public int LearningTypeId { get; set; }
        public int LearningLevelId { get; set; }
        public LearningType LearningType { get; set; }
        public LearningLevel LearningLevel { get; set; }
        public List<CLOToSubject> CLOToSubjects { get; set; }

    }
}
