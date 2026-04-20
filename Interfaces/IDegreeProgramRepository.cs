using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.Interfaces
{
    public interface IDegreeProgramRepository : IBaseRepository<DegreeProgram>
    {
        public void Save();
    }
}
