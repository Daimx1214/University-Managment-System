using UniversityManagementSystem.Database;

namespace UniversityManagmentSystem.Repositories
{
    public class StructureUnitRepository : BaseRepository<Model.StructureUnit>, Interfaces.IStructureUnitRepository
    {
        private readonly UniversityDbContext _context;
        public StructureUnitRepository(UniversityDbContext context) : base(context)
        {
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
