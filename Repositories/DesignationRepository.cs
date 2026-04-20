using UniversityManagementSystem.Database;

namespace UniversityManagmentSystem.Repositories
{
    public class DesignationRepository : BaseRepository<Model.Designation> , Interfaces .IDesignationRepository
    {
        private readonly UniversityDbContext _dbContext;
        public DesignationRepository(UniversityDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

    }
}
