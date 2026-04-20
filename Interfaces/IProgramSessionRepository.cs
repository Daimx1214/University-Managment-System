using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.Interfaces
{
    public interface IProgramSessionRepository :IBaseRepository<ProgramSession>
    {
        public void Save();
    }
   
}
