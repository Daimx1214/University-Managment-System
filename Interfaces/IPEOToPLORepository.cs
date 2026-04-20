using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.Interfaces
{
    public interface IPEOToPLORepository : IBaseRepository<PEOToPLO>
    {
        public void Save();
    }
}
