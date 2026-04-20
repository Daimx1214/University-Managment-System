using UniversityManagementSystem.Database;

namespace UniversityManagmentSystem.Repositories
{
    public class CourseSchemeRepository : BaseRepository<Model.CourseScheme>, Interfaces.ICourseSchemeRepository
    {
        private readonly UniversityDbContext _context;
        public CourseSchemeRepository(UniversityDbContext context) : base(context)
        {
            _context = context;
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
