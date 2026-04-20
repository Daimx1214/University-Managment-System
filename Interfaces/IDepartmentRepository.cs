using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.Interfaces
{
    public interface IDepartmentRepository : IBaseRepository<Department>
    {
        public void Save();
    }
}
