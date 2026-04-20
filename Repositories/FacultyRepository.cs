using UniversityManagementSystem.Database;

namespace UniversityManagmentSystem.Repositories
{
    public class FacultyRepository : BaseRepository<Model.Faculty>, Interfaces.IFacultyRepository
    {
        private readonly UniversityDbContext _dbContext;
        public FacultyRepository(UniversityDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
