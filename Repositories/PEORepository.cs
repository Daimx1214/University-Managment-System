using UniversityManagementSystem.Database;

namespace UniversityManagmentSystem.Repositories
{
    public class PEORepository : BaseRepository<Model.PEO>,Interfaces.IPEORepository
    {
        private readonly UniversityDbContext _context;
        public PEORepository(UniversityDbContext context) : base(context)
        {
            _context = context;
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
