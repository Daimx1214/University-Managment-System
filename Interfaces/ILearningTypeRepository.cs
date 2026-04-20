using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.Interfaces
{
    public interface ILearningTypeRepository : IBaseRepository<LearningType>
    {
        public void Save();
    }
}
