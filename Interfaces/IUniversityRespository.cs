using UniversityManagementSystem.Model;

namespace UniversityManagmentSystem.Interfaces
{
    public interface IUniversityRespository : IBaseRepository<University>
    {
        public void Save();
    }
}
