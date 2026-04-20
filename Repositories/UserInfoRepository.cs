using UniversityManagementSystem.Database;

namespace UniversityManagmentSystem.Repositories
{
    public class UserInfoRepository : BaseRepository<Model.UserInfo> , Interfaces.IUserInfoRepository
    {
        private readonly UniversityDbContext _context;
        public UserInfoRepository(UniversityDbContext context) : base(context)
        {
            _context = context;
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
