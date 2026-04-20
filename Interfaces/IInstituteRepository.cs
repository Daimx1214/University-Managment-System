using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.Interfaces
{
    public interface IInstituteRepository : IBaseRepository<Institute>
    {
        public void Save();
    }
}
