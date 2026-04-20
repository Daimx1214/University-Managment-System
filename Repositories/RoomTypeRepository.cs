using Microsoft.EntityFrameworkCore;
using UniversityManagementSystem.Database;
using UniversityManagementSystem.Model;
using UniversityManagementSystem.Interfaces;

namespace UniversityManagementSystem.Repositories
{
    public class RoomTypeRepository : BaseRepository<RoomType>, IRoomTypeRepository
    {
        private readonly UniversityDbContext _dbContext;

        public RoomTypeRepository(UniversityDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
