using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.Interfaces
{
    public interface IUserTypeRepository : IBaseRepository<UserType>
    {
        public void Save();
    }
}
