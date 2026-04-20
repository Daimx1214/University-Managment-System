using UniversityManagementSystem.Database;

namespace UniversityManagmentSystem.Repositories
{
    public class FacultyCampusRepository : BaseRepository<Model.FacultyCampus> , Interfaces.IFacultyCampusRepository
    {
        private readonly UniversityDbContext _context;
        public FacultyCampusRepository(UniversityDbContext context) : base(context)
        {
            _context = context;
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
