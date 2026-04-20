using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.Interfaces
{
    public interface IFacultyRepository : IBaseRepository<Faculty>
    {
        public void Save();
    }
   
}
