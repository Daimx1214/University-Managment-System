using UniversityManagementSystem.Model;

namespace UniversityManagmentSystem.Model
{
    public class UserRightAllocation : BaseModel
    {
        public int UserRightID { get; set; }
        public int UserTypeId { get; set; }
        public UserRight UserRight { get; set; }
        public UserType UserType { get; set; }

    }
}
