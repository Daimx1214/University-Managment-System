using UniversityManagementSystem.Model;

namespace UniversityManagmentSystem.Model
{
    public class Department : BaseModel
    {
        public string DepartmentName { get; set; }
        public string Description { get; set; }
        public DateTime EstablishedIn { get; set; }
        public string Code { get; set; }
        public int InstituteId { get; set; }
        Institute Institute { get; set; }
        public List<DegreeProgram> DegreeProgram { get; set; }
    }
}
