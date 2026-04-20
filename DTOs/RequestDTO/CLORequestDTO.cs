namespace UniversityManagmentSystem.DTOs.RequestDTO
{
    public class CLORequestDTO
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public int LearningTypeId { get; set; }
        public int LearningLevelId { get; set; }
    }
}
