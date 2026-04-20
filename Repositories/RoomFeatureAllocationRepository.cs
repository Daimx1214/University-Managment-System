using UniversityManagementSystem.Database;
using UniversityManagementSystem.Model;
using UniversityManagmentSystem.Interfaces;

namespace UniversityManagmentSystem.Repositories
{
    public class RoomFeatureAllocationRepository : BaseRepository<RoomFeatureAllocation>, IRoomFeatureAllocationRepository
    {
        private readonly UniversityDbContext _context;
        public RoomFeatureAllocationRepository(UniversityDbContext context) : base(context)
        {
            _context = context; 
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
