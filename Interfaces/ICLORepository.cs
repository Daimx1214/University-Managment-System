using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.Interfaces
{
    public interface ICLORepository : IBaseRepository<CLO>
    {
        public void Save();
    }
}
