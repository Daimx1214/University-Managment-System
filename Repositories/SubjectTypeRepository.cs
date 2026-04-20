using UniversityManagementSystem.Database;

namespace UniversityManagmentSystem.Repositories
{
    public class SubjectTypeRepository : BaseRepository<Model.SubjectType>, Interfaces.ISubjectTypeRepository
    {
        private readonly UniversityDbContext _dbContext;
        public SubjectTypeRepository(UniversityDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}

