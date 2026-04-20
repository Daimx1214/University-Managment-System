using UniversityManagementSystem.Model;

namespace UniversityManagmentSystem.Model
{
    public class CourseScheme : BaseModel
    {
        public int SubjectId { get; set; }
        public int SubjectTypeId { get; set; }
        public int CreditHours { get; set; }
        public int DegreeProgramId { get; set; }
        public int ProgramSessionId { get; set; }
        public int SemesterId { get; set; }
        SubjectType SubjectType { get; set; }
        DegreeProgram DegreeProgram { get; set; }
        ProgramSession ProgramSession { get; set; }
        Subject Subject { get; set; }
        Semester Semester { get; set; }
    }
}
