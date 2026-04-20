using UniversityManagementSystem.Model;

namespace UniversityManagmentSystem.Interfaces
{
    public interface IRoomFeatureAllocationRepository : IBaseRepository<RoomFeatureAllocation>
    {
        public void Save();
    }
}
