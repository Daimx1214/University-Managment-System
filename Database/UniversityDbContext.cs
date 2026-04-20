using Microsoft.EntityFrameworkCore;
using UniversityManagementSystem.Model;
using UniversityManagmentSystem.Model;

namespace UniversityManagementSystem.Database
{
    public class UniversityDbContext : DbContext
    {
        public UniversityDbContext(DbContextOptions options) : base(options) { }
        DbSet<University> University { get; set; }
        DbSet<Campus> Campuses { get; set; }
        DbSet<Block> Blocks { get; set; }
        DbSet<Building> Buildings { get; set; }
        DbSet<Floor> Floors { get; set; }
        DbSet<Room> Rooms { get; set; }
        DbSet<RoomType> RoomTypes { get; set; }
        DbSet<RoomFeature> RoomFeatures { get; set; }
        DbSet<RoomTypeAllocation> RoomTypesAllocation { get; set; }
        DbSet<RoomFeatureAllocation> RoomFeaturesAllocation { get; set; }
        DbSet<CourseScheme> CourseSchemes { get; set; }
        DbSet<DegreeLevel> DegreeLevels { get; set; }
        DbSet<DegreeProgram> DegreeProgram { get; set; }
        DbSet<Department> Departments { get; set; }
        DbSet<Designation> Designations { get; set; }
        DbSet<Faculty> Faculty { get; set; }
        DbSet<FacultyCampus> FacultyCampuses { get; set; }
        DbSet<Institute> Institutes { get; set; }
        DbSet<ProgramSession> ProgramSessions { get; set; }
        DbSet<Semester> Semesters { get; set; }
        DbSet<StructureDesignation> StructureDesignations { get; set; }
        DbSet<StructureType> StructureTypes { get; set; }
        DbSet<StructureUnit> StructureUnits { get; set; }
        DbSet<Subject> Subjects { get; set; }
        DbSet<SubjectType> SubjectTypes { get; set; }
        DbSet<CLO> CLOs { get; set; }
        DbSet<CLOToSubject> CLOToSubjects { get; set; }
        DbSet<LearningLevel> LearningLevels { get; set; }
        DbSet<LearningType> LearningTypes { get; set; }
        DbSet<PEO> PEOs { get; set; }
        DbSet<PEOToPLO> PEOToPLOs { get; set; }
        DbSet<PLO> PLOs { get; set; }
        DbSet<PLOToCLO> PLOToCLOs{ get; set; }
        DbSet<UserInfo> UserInfos { get; set; }
        DbSet<UserType> UserTypes { get; set; }
        DbSet<UserRight> UserRights { get; set; }
        DbSet<UserTypeAllocation> UserTypeAllocations { get; set; }
        DbSet<UserRightAllocation> UserRightAllocations { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
