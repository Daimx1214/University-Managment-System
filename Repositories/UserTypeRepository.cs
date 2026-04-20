using UniversityManagementSystem.Database;

namespace UniversityManagmentSystem.Repositories
{
    public class UserTypeRepository : BaseRepository<Model.UserType>,Interfaces.IUserTypeRepository
    { 
        private readonly UniversityDbContext _context;
        public UserTypeRepository(UniversityDbContext context) : base(context) 
        {
            _context = context;
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
