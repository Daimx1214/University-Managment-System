namespace UniversityManagmentSystem.DTOs.RequestDTO
{
    public class DepartmentRequestDTO
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public string Description { get; set; }
        public DateTime EstablishedIn { get; set; }
        public string Code { get; set; }
        public int InstituteId { get; set; }
    }
}
