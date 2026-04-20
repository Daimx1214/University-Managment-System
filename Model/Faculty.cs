using UniversityManagementSystem.Model;

namespace UniversityManagmentSystem.Model
{
    public class Faculty : BaseModel
    {
        public string FacultyName { get; set; }
        public string Occupation { get; set; }
        public string Code { get; set; }
        public DateTime EstablishedIn { get; set; }
        List<FacultyCampus> FacultyCampus { get; set; }
    }
}
