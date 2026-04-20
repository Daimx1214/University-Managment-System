using UniversityManagementSystem.Database;

namespace UniversityManagmentSystem.Repositories
{
    public class SemesterRepository : BaseRepository<Model.Semester>, Interfaces.ISemesterRepository
    {
        private readonly UniversityDbContext _dbContext;
        public SemesterRepository(UniversityDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
