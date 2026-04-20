using UniversityManagementSystem.Database;

namespace UniversityManagmentSystem.Repositories
{
    public class StructureDesignationRepository : BaseRepository<Model.StructureDesignation>, Interfaces.IStructureDesignationRepository
    {
        private readonly UniversityDbContext _context;
        public StructureDesignationRepository(UniversityDbContext context) : base(context)
        {
            _context = context;
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
