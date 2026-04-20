using Microsoft.Identity.Client;
using UniversityManagementSystem.Database;

namespace UniversityManagmentSystem.Repositories
{
    public class UserRightRepository : BaseRepository<Model.UserRight>,Interfaces.IUserRightRepository
    {
        private readonly UniversityDbContext _context;
        public UserRightRepository(UniversityDbContext context) : base(context) 
        {
            _context = context;
        }
        public void Save()
        {
            _context.SaveChanges();
        }

    }
}
