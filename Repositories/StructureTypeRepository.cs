using UniversityManagementSystem.Database;

namespace UniversityManagmentSystem.Repositories
{
    public class StructureTypeRepository : BaseRepository<Model.StructureType>, Interfaces.IStructureTypeRepository
    {
        private readonly UniversityDbContext _dbContext;
        public StructureTypeRepository(UniversityDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}

