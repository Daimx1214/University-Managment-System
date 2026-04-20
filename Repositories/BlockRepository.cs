using UniversityManagementSystem.Database;

namespace UniversityManagmentSystem.Repositories
{
    public class BlockRepository : BaseRepository<Model.Block>, Interfaces.IBlockRepository
    {
        private readonly UniversityDbContext _dbcontext;
        public BlockRepository(UniversityDbContext dbcontext) : base(dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public void Save()
        {
            _dbcontext.SaveChanges();
        }
    }}
