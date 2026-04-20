using UniversityManagementSystem.Model;

namespace UniversityManagmentSystem.Interfaces
{
    public interface ICampusRepository : IBaseRepository<Campus>
    {
        public void Save();
    }
}
