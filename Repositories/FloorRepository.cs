using UniversityManagementSystem.Database;
using UniversityManagementSystem.Model;
using UniversityManagmentSystem.Interfaces;

namespace UniversityManagmentSystem.Repositories
{
    public class FloorRepository : BaseRepository<Floor>, IFloorRepository
    {
        private readonly UniversityDbContext _context;

        public FloorRepository(UniversityDbContext context) : base(context)
        {
            _context = context;
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}

