using Microsoft.EntityFrameworkCore;
using UniversityManagementSystem.Database;

namespace UniversityManagmentSystem.Repositories
{
    public class ProgramSessionRepository : BaseRepository<Model.ProgramSession>, Interfaces.IProgramSessionRepository
    {
        private readonly UniversityDbContext _dbContext;
        public ProgramSessionRepository(UniversityDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}

