namespace UniversityManagmentSystem.DTOs.RequestDTO
{
    public class InstituteRequestDTO
    {
        public int Id { get; set; }
        public string InstituteName { get; set; }
        public string Description { get; set; }
        public DateTime EstablishedIn { get; set; }
        public string Code { get; set; }
        public int FacultyCampusId { get; set; }
    }
}
