using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.Interfaces
{
    public interface ICourseSchemeRepository : IBaseRepository<CourseScheme>
    {
        public void Save();
    }
}
