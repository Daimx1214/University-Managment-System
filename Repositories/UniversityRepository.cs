using UniversityManagementSystem.Database;
using UniversityManagementSystem.Model;
using UniversityManagmentSystem.Interfaces;

namespace UniversityManagmentSystem.Repositories
{
    public class UniversityRepository : BaseRepository<University>,IUniversityRespository
    {
        private readonly UniversityDbContext _dbContext;
        public UniversityRepository(UniversityDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
