using UniversityManagementSystem.Model;
using UniversityManagmentSystem.Interfaces;

namespace UniversityManagementSystem.Interfaces
{
    public interface IRoomTypeRepository : IBaseRepository<RoomType>
    {
        void Save();
    }
}
