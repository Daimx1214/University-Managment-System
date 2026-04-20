using UniversityManagementSystem.Database;

namespace UniversityManagmentSystem.Repositories
{
    public class DegreeProgramRepository : BaseRepository<Model.DegreeProgram>, Interfaces.IDegreeProgramRepository
    {
        private readonly UniversityDbContext _context;
        public DegreeProgramRepository(UniversityDbContext context) : base(context)
        {
            _context = context;
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
