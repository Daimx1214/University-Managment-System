using UniversityManagementSystem.Database;

namespace UniversityManagmentSystem.Repositories
{
    public class UserTypeAllocationRepository : BaseRepository<Model.UserTypeAllocation>,Interfaces.IUserTypeAllocationRepository
    {
        private readonly UniversityDbContext _universityDb;
        public UserTypeAllocationRepository(UniversityDbContext universityDb)  : base(universityDb) 
        {
            _universityDb = universityDb;
        }
        public void Save()
        {
            _universityDb.SaveChanges();
        }
    }
}
