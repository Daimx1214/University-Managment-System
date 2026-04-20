using Microsoft.Identity.Client;
using UniversityManagementSystem.Database;
using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.Repositories
{
    public class PEOToPLORepository : BaseRepository< Model.PEOToPLO>, Interfaces.IPEOToPLORepository
    {
        private readonly UniversityDbContext _context;
        public PEOToPLORepository(UniversityDbContext context) : base(context)
        {
            _context = context;
        }
        public void Save()
        {
            _context.SaveChanges();
        }

    }
}
