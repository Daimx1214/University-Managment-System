using UniversityManagementSystem.Model;
using UniversityManagmentSystem.Interfaces;

namespace UniversityManagementSystem.Interfaces
{
    public interface IRoomFeatureRepository : IBaseRepository<RoomFeature>
    {
        void Save();
    }
}
