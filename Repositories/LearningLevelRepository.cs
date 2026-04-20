using UniversityManagementSystem.Database;

namespace UniversityManagmentSystem.Repositories
{
    public class LearningLevelRepository : BaseRepository<Model.LearningLevel>, Interfaces.ILearningLevelRepository
    {
        private readonly UniversityDbContext _context;
        public LearningLevelRepository(UniversityDbContext context) : base(context)
        {
            _context = context;
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
