using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.Interfaces
{
    public interface IUserRightRepository : IBaseRepository<UserRight>
    {
        public void Save();
    }

}
