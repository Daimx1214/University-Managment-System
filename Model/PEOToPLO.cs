using UniversityManagementSystem.Model;

namespace UniversityManagmentSystem.Model
{
    public class PEOToPLO : BaseModel
    {
        public int  Id { get; set; }
        public int Weightage { get; set; }
        public int PEOId { get; set; }
        public int PLOId { get; set; }
        public PEO PEO { get; set; }
        public PLO PLO { get; set; }
    }
}
