namespace UniversityManagmentSystem.DTOs.RequestDTO
{
    public class BlockRequestDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateTime EstablishedIn { get; set; }
        public int Code { get; set; }
    }
}
