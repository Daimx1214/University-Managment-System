using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.Interfaces
{
    public interface IUserRightAllocationRepository : IBaseRepository<UserRightAllocation>
    {
        public void Save();
    }
}
