using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.Interfaces
{
    public interface IUserTypeAllocationRepository : IBaseRepository<UserTypeAllocation>
    {
        public void Save();
    }
}
