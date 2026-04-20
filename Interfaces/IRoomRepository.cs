using UniversityManagementSystem.Model;

namespace UniversityManagmentSystem.Interfaces
{
    public interface IRoomRepository : IBaseRepository<Room>
    {
        public void Save();
    }
}
