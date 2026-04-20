using UniversityManagementSystem.Database;

namespace UniversityManagmentSystem.Repositories
{
    public class InstituteRepository : BaseRepository<Model.Institute>, Interfaces.IInstituteRepository
    {
        private readonly UniversityDbContext _context;
        public InstituteRepository(UniversityDbContext context) : base(context)
        {
            _context = context;
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
