using UniversityManagementSystem.Model;

namespace UniversityManagmentSystem.Model
{
    public class Block : BaseModel
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateTime EstablishedIn { get; set; }
        public int Code { get; set; }

    }
}
