namespace UniversityManagmentSystem.DTOs.RequestDTO
{
    public class RoomFeatureAllocationRequestDTO
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public int RoomFeatureId { get; set; }
        public int Quantity { get; set; }
    }
}
