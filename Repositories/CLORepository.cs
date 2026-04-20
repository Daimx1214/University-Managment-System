using UniversityManagementSystem.Database;

namespace UniversityManagmentSystem.Repositories
{
    public class CLORepository : BaseRepository<Model.CLO>, Interfaces.ICLORepository
    {
        private readonly UniversityDbContext _context;
        public CLORepository(UniversityDbContext context) : base(context)
        {
            _context = context;
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
