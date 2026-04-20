namespace UniversityManagmentSystem.DTOs.RequestDTO
{
    public class CourseSchemeRequestDTO
    {
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public int SubjectTypeId { get; set; }
        public int CreditHours { get; set; }
        public int DegreeProgramId { get; set; }
        public int ProgramSessionId { get; set; }
        public int SemesterId { get; set; }
    }
}
