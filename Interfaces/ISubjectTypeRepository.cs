using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.Interfaces
{
    public interface ISubjectTypeRepository : IBaseRepository<SubjectType>
    {
        public void Save();
    }
}
