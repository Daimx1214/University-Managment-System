using UniversityManagementSystem.Database;

namespace UniversityManagmentSystem.Repositories
{
    public class DepartmentRepository : BaseRepository<Model.Department>, Interfaces.IDepartmentRepository
    {
        private readonly UniversityDbContext _context;
        public DepartmentRepository(UniversityDbContext context) : base(context)
        {
            _context = context;
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
