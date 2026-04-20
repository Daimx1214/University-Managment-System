namespace UniversityManagmentSystem.DTOs.RequestDTO
{
    public class FloorRequestDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }
        public string? Description { get; set; }
        public DateTime EstablishedIn { get; set; }
        public string? Address { get; set; }
        public int BuildingId { get; set; }
    }
}
