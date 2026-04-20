using UniversityManagementSystem.Model;

namespace UniversityManagmentSystem.Interfaces
{
    public interface IFloorRepository : IBaseRepository<Floor>
    {
        public void Save();
    }
}
