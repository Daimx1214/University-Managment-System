using UniversityManagementSystem.Database;

namespace UniversityManagmentSystem.Repositories
{
    public class PLORepository : BaseRepository<Model.PLO>, Interfaces.IPLORepository
    {
        private readonly UniversityDbContext _context;
        public PLORepository(UniversityDbContext context) : base(context)
        {
            _context = context;
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
