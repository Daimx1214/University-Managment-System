using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.Interfaces
{
    public interface IFacultyCampusRepository : IBaseRepository<FacultyCampus>
    {
        public void Save();
    }
}
