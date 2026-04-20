using UniversityManagementSystem.Model;

namespace UniversityManagmentSystem.Model
{
    public class CLOToSubject : BaseModel

    {
        public int CLOId { get; set; }
        public int CourseSchemeId { get; set; }
        public int ProgramSessionId { get; set; }
        public CLO CLO { get; set; }
        public Subject Subject { get; set; }
        public ProgramSession ProgramSession { get; set; }

    }
}
