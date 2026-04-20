namespace UniversityManagmentSystem.DTOs.RequestDTO
{
    public class UserTypeAllocationRequestDTO
    {
        public int Id { get; set; }
        public int UserTypeId { get; set; }
        public int UserInfoId { get; set; }
        public int DepartmentId { get; set; }
        public int ProgramId { get; set; }
    }
}
