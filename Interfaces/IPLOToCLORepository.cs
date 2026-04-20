using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.Interfaces
{
    public interface IPLOToCLORepository : IBaseRepository<PLOToCLO>
    {
        public void Save();
    }
}
