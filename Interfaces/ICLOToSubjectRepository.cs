using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.Interfaces
{
    public interface ICLOToSubjectRepository : IBaseRepository<CLOToSubject>
    {
        public void Save();
    }
}
