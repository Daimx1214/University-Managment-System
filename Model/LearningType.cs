using UniversityManagementSystem.Model;

namespace UniversityManagmentSystem.Model
{
    public class LearningType : BaseModel
    {
        public string Description { get; set; }
        public string Code { get; set; }
        public List<CLO> CLOs { get; set; }
    }
}
