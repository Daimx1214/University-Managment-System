using UniversityManagementSystem.Model;

namespace UniversityManagmentSystem.Model
{
    public class UserInfo : BaseModel
    {
        public string UiUser { get; set; }
        public string UiPass { get; set; }
        public string UserName { get; set; }
        public List<UserTypeAllocation> userTypeAllocations { get; set; }

    }
}
