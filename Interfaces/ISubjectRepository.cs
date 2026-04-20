using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.Interfaces
{
    public interface ISubjectRepository : IBaseRepository<Subject>
    {
        public void Save();
    }
}
