using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.Interfaces
{
    public interface ISemesterRepository : IBaseRepository<Semester>
    {
        public void Save();
    }
}
