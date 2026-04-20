using UniversityManagementSystem.Database;

namespace UniversityManagmentSystem.Repositories
{
    public class CLOToSubjectRepository : BaseRepository<Model.CLOToSubject>, Interfaces.ICLOToSubjectRepository
    {
        private readonly UniversityDbContext _context;
        public CLOToSubjectRepository(UniversityDbContext context) : base(context)
        {
            _context = context;
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
