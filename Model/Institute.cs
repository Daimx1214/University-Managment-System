using UniversityManagementSystem.Model;

namespace UniversityManagmentSystem.Model
{
    public class Institute : BaseModel
    {
        public string InstituteName { get; set; }
        public string Description { get; set; }
        public DateTime EstablishedIn { get; set; }
        public string Code { get; set; }
        public int FacultyCampusId { get; set; }
        FacultyCampus FacultyCampus { get; set; }
        public List<Department> Department { get; set; }
    }
}
