using UniversityManagementSystem.Database;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.Repositories
{
    public class LearningTypeRepository : BaseRepository<Model.LearningType>,Interfaces.ILearningTypeRepository
    {
        private readonly UniversityDbContext _context;

        public LearningTypeRepository(UniversityDbContext context) : base(context)
        {
            _context = context;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
