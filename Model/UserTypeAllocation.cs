using UniversityManagementSystem.Model;

namespace UniversityManagmentSystem.Model
{
    public class UserTypeAllocation : BaseModel
    {
        public int UserTypeId { get; set; }
        public int UserInfoId { get; set; }
        public int DepartmentId { get; set; }
        public int ProgramId { get; set; }
        public UserType UserType { get; set; }
        public UserInfo UserInfo { get; set; }
        public Department Department { get; set; }
        public ProgramSession Program { get; set; }

    }
}
