namespace UniversityManagmentSystem.DTOs.RequestDTO
{
    public class DegreeProgramRequestDTO
    {
        public int Id { get; set; }
        public string DegreeProgramName { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public int DegreeLevelId { get; set; }
        public int DepartmentId { get; set; }
    }
}
