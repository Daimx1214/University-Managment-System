using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.Interfaces
{
    public interface ILearningLevelRepository : IBaseRepository<LearningLevel>
    {
        public void Save();
    }
}
