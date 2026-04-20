using UniversityManagementSystem.Database;
using UniversityManagmentSystem.Interfaces;

namespace UniversityManagmentSystem.Repositories
{
    public class PLOToCLORepository : BaseRepository<Model.PLOToCLO>, Interfaces.IPLOToCLORepository
    {
        private readonly UniversityDbContext _universityDbContext;
        public PLOToCLORepository(UniversityDbContext universityDbContext) : base(universityDbContext)
        {
            _universityDbContext = universityDbContext;
        }
        public void Save()
        {
            _universityDbContext.SaveChanges();
        }

    }
}
