using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.Interfaces
{
    public interface IStructureDesignationRepository : IBaseRepository<StructureDesignation>
    {
        public void Save();
    }
}
