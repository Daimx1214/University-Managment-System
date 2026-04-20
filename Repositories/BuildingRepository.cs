using UniversityManagementSystem.Database;

namespace UniversityManagmentSystem.Repositories
{
    public class BuildingRepository : BaseRepository<Model.Building>, Interfaces.IBuildingRepository
    {
        private readonly UniversityDbContext _context;
        public BuildingRepository(UniversityDbContext context) : base(context)
        {
            _context = context;
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
