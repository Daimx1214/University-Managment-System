using Microsoft.EntityFrameworkCore;
using UniversityManagementSystem.Database;
using UniversityManagementSystem.Interfaces;
using UniversityManagementSystem.Repositories;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Model;
using UniversityManagmentSystem.Repositories;
using UniversityManagmentSystem.Services;
var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddDbContext<UniversityDbContext>(db => db.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection")));
builder.Services.AddControllers();
builder.Services.AddScoped<IUniversityRespository, UniversityRepository>();
builder.Services.AddScoped<UniversityServices>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IDesignationRepository, DesignationRepository>();
builder.Services.AddScoped<IFacultyRepository, FacultyRepository>();
builder.Services.AddScoped<IDegreeLevelRepository, DegreeLevelRepository>();
builder.Services.AddScoped<ISubjectRepository, SubjectRepository>();
builder.Services.AddScoped<IProgramSessionRepository, ProgramSessionRepository>();
builder.Services.AddScoped<IRoomFeatureRepository, RoomFeatureRepository>();
builder.Services.AddScoped<IRoomTypeRepository, RoomTypeRepository>();
builder.Services.AddScoped<ISemesterRepository, SemesterRepository>();
builder.Services.AddScoped<ISubjectTypeRepository, SubjectTypeRepository>();
builder.Services.AddScoped<IStructureTypeRepository, StructureTypeRepository>();
builder.Services.AddScoped<IBlockRepository, BlockRepository>();
builder.Services.AddScoped<IBuildingRepository, BuildingRepository>();
builder.Services.AddScoped<ICampusRepository, CampusRepository>();
builder.Services.AddScoped<ICLORepository, CLORepository>();
builder.Services.AddScoped<ICLOToSubjectRepository, CLOToSubjectRepository>();
builder.Services.AddScoped<ICourseSchemeRepository, CourseSchemeRepository>();
builder.Services.AddScoped<IDegreeProgramRepository, DegreeProgramRepository>();
builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
builder.Services.AddScoped<IFacultyCampusRepository, FacultyCampusRepository>();
builder.Services.AddScoped<IFloorRepository, FloorRepository>();
builder.Services.AddScoped<IInstituteRepository, InstituteRepository>();
builder.Services.AddScoped<ILearningLevelRepository, LearningLevelRepository>();
builder.Services.AddScoped<ILearningTypeRepository, LearningTypeRepository>();
builder.Services.AddScoped<IPEORepository, PEORepository>();
builder.Services.AddScoped<IPEOToPLORepository, PEOToPLORepository>();
builder.Services.AddScoped<IPLORepository, PLORepository>();
builder.Services.AddScoped<IPLOToCLORepository, PLOToCLORepository>();
builder.Services.AddScoped<IRoomRepository, RoomRepository>();
builder.Services.AddScoped<IRoomFeatureAllocationRepository, RoomFeatureAllocationRepository>();
builder.Services.AddScoped<IRoomTypeAllocationRepository, RoomTypeAllocationRepository>();
builder.Services.AddScoped <IStructureUnitRepository, StructureUnitRepository>();
builder.Services.AddScoped<IStructureDesignationRepository, StructureDesignationRepository>();
builder.Services.AddScoped <IUserInfoRepository, UserInfoRepository>();
builder.Services.AddScoped<IUserTypeRepository, UserTypeRepository>();
builder.Services.AddScoped <IUserRightRepository, UserRightRepository>();
builder.Services.AddScoped <IUserRightAllocationRepository, UserRightAllocationRepository>();
builder.Services.AddScoped <IUserTypeAllocationRepository, UserTypeAllocationRepository>();



builder.Services.AddScoped<DesignationServices>();
builder.Services.AddScoped<FacultyServices>();
builder.Services.AddScoped<DegreeLevelServices>();
builder.Services.AddScoped<SubjectServices>();
builder.Services.AddScoped<ProgramSessionServices>();
builder.Services.AddScoped<RoomFeatureServices>();
builder.Services.AddScoped<RoomTypeServices>();
builder.Services.AddScoped<SemesterServices>();
builder.Services.AddScoped<SubjectTypeServices>();
builder.Services.AddScoped<StructureTypeServices>();
builder.Services.AddScoped<BlockServices>();
builder.Services.AddScoped<BuildingServices>();
builder.Services.AddScoped<CampusServices>();
builder.Services.AddScoped<CLOServices>();
builder.Services.AddScoped<CLOToSubjectServices>();
builder.Services.AddScoped<CourseSchemeServices>();
builder.Services.AddScoped<DegreeProgramServices>();
builder.Services.AddScoped<DepartmentServices>();
builder.Services.AddScoped<FacultyCampusServices>();
builder.Services.AddScoped<StructureDesignationServices>();
builder.Services.AddScoped<FloorServices>();
builder.Services.AddScoped<InstituteServices>();
builder.Services.AddScoped<LearningLevelServices>();
builder.Services.AddScoped<LearningTypeServices>();
builder.Services.AddScoped<PEOServices>();
builder.Services.AddScoped<PEOToPLOServices>();
builder.Services.AddScoped<PLOServices>();
builder.Services.AddScoped<PLOToCLOServices>();
builder.Services.AddScoped<RoomServices>();
builder.Services.AddScoped<RoomFeatureAllocationServices>();
builder.Services.AddScoped<RoomTypeAllocationServices>();
builder.Services.AddScoped<StructureUnitServices>();
builder.Services.AddScoped<UserInfoServices>();
builder.Services.AddScoped<UserTypeServices>();
builder.Services.AddScoped<UserRightServices>();
builder.Services.AddScoped<UserRightAllocationServices>();
builder.Services.AddScoped<UserTypeAllocationServices>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
