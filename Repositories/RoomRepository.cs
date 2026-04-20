using UniversityManagementSystem.Database;
using UniversityManagementSystem.Model;
using UniversityManagmentSystem.Interfaces;

namespace UniversityManagmentSystem.Repositories
{
    public class RoomRepository : BaseRepository<Room>, IRoomRepository
    {
        private readonly UniversityDbContext _context;
        public RoomRepository(UniversityDbContext context) : base(context)
        {
            _context = context;
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
