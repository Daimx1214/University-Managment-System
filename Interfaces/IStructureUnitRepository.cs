using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.Interfaces
{
    public interface IStructureUnitRepository : IBaseRepository<StructureUnit>
    {
        public void Save();
    }
}
