namespace UniversityManagmentSystem.DTOs.RequestDTO
{
    public class StructureUnitRequestDTO
    {
        public int Id { get; set; }
        public string StructureUnitName { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public int StructureTypeId { get; set; }
    }
}
