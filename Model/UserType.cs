using UniversityManagementSystem.Model;

namespace UniversityManagmentSystem.Model
{
    public class UserType :BaseModel
    {
        public string UserTypeCode { get; set; }
        public string UserName { get; set; }
        public List<UserRightAllocation> userRightAllocations { get; set; }
        public List<UserTypeAllocation> userTypeAllocations { get; set; }

    }
}
