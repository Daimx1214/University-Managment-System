using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.Interfaces
{
    public interface IBuildingRepository : IBaseRepository<Building>
    {
        public void Save();
    }
}
