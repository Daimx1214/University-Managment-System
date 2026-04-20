using UniversityManagementSystem.Model;

namespace UniversityManagmentSystem.Model
{
    public class PLOToCLO : BaseModel
    {
        public int PLOId { get; set; }
        public int CLOId { get; set; }
        public PLO PLO { get; set; }
        public CLO CLO { get; set; }
    }
}
