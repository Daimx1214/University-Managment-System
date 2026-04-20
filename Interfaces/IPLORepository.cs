using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.Interfaces
{
    public interface IPLORepository : IBaseRepository<PLO>
    {
        public void Save();
    }
}
