using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.Interfaces
{
    public interface IPEORepository : IBaseRepository<PEO>
    {
        public void Save();

    }
}
