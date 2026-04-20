namespace UniversityManagmentSystem.DTOs.ResponseDTP
{
    public class UniversityResponseDTO : BaseResponseDTO
    {
        public string Description { get; set; }
        public string UniversityName { get; set; }
        public DateTime EstablishedIn { get; set; }
        public string Address { get; set; }
    }
}
