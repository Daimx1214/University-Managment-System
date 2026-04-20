using UniversityManagementSystem.Database;
using UniversityManagementSystem.Model;
using UniversityManagmentSystem.Interfaces;

namespace UniversityManagmentSystem.Repositories
{
    public class CampusRepository : BaseRepository<Campus>, ICampusRepository
    {
        private readonly UniversityDbContext _context;
        public CampusRepository(UniversityDbContext context) : base(context)
        {
            _context = context;
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
