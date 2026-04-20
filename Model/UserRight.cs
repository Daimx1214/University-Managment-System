using UniversityManagementSystem.Model;

namespace UniversityManagmentSystem.Model
{
    public class UserRight : BaseModel
    {
        public string RightCode { get; set; }
        public string UserRightName { get; set; }
        public string URL { get; set; }
        public string TabName { get; set; }
        public List<UserRightAllocation> userRightAllocations { get; set; }

    }
}
