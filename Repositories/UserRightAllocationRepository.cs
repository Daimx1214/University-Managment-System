using UniversityManagementSystem.Database;

namespace UniversityManagmentSystem.Repositories
{
    public class UserRightAllocationRepository : BaseRepository<Model.UserRightAllocation>, Interfaces.IUserRightAllocationRepository

    {
        private readonly UniversityDbContext _context;
        public UserRightAllocationRepository(UniversityDbContext context) : base(context) 
        {
            _context = context;
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    } 
}
