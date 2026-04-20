using UniversityManagementSystem.Database;

namespace UniversityManagementSystem.Repositories
{
    public class RoomFeatureRepository : BaseRepository<Model.RoomFeature>, Interfaces.IRoomFeatureRepository
    {
        private readonly UniversityDbContext _dbContext;

        public RoomFeatureRepository(UniversityDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
