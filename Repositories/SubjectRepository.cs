using UniversityManagementSystem.Database;

namespace UniversityManagmentSystem.Repositories
{
    public class SubjectRepository : BaseRepository<Model.Subject>, Interfaces.ISubjectRepository
    {
        private readonly UniversityDbContext _dbContext;
        public SubjectRepository(UniversityDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
