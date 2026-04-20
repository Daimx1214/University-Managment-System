using UniversityManagementSystem.Model;

namespace UniversityManagmentSystem.Interfaces
{
    public interface IRoomTypeAllocationRepository : IBaseRepository<RoomTypeAllocation>
    {
        public void Save();
    }
}
