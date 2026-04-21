**University Management System — .NET & EF Core**
A console-based **University Management System** built with C# (.NET) and **Entity Framework Core**, implementing a fully normalized relational database schema via code-first migrations. Features advanced LINQ operations, repository-pattern data access, and complex entity relationships spanning students, instructors, academic departments, course catalogs, and enrollment records.
✨ Features
The University Management System provides a full-suite REST API covering every dimension of university operations. Each module is implemented as a dedicated controller with complete CRUD support.
Table
Feature	Description	Endpoint
🏛️ Academic Setup	Manage universities, campuses, faculties, institutes & departments	/api/University
👨‍🎓 Student Management	Student registration, enrollment, program & session tracking	/api/Student
👔 Employee & HR	Employee records, designations, relation histories & payroll structures	/api/Employee
📚 Library System	Books, copies, issuances, reservations, returns & fine management	/api/ItemInfo
📋 Circulation Rules	Configure loan limits, grace days, overdue fines per member type	/api/CirculationRule
💰 Fine Management	Fine categories, definitions, user fines & payment transactions	/api/UserFine
🛒 Acquisitions	Item quotations, purchase orders & acquisition records	/api/PurchaseItem
🏢 Physical Structure	Buildings, blocks, floors, rooms, room types & feature allocations	/api/Building
🔢 Accession Control	Accession number patterns per branch for systematic item cataloguing	/api/AccessionPattern
📦 Item Conditions	Track physical condition & remarks for every item copy	/api/ItemCondition
📄 Requisitions	Library & item requisition workflows with employee approval chain	/api/LibraryRequisition
🗑️ Withdrawals	Withdraw damaged or decommissioned item copies with audit trail	/api/Withdrawal
🛡️ Soft Delete	All records are soft-deleted (IsActive flag) — no data loss ever	All endpoints
⏰ Auto Timestamps	CreatedAt, UpdatedAt, DeletedAt auto-populated on every operation	All endpoints
📖 Swagger UI	Interactive API documentation available at application root	/
🔄 Auto Migration	Database schema applied automatically on every application startup	Program.cs
🛠️ Tech Stack
Table
Layer	Technology	Version
Framework	ASP.NET Core	8.0 (net8.0)
Language	C#	12.0
ORM	Entity Framework Core	8.0.0
Database	Microsoft SQL Server	2019 / 2022
DB Driver	Microsoft.Data.SqlClient	EF bundled
API Documentation	Swashbuckle / Swagger UI	6.6.2
Architecture	REST Web API (MVC)	Controller-based
Pattern	Repository / Service Layer	GenericService<T>
Response Format	JSON (ApiResponse wrapper)	Custom
Delete Strategy	Soft Delete (IsActive)	Custom BaseModel
📁 Project Structure
The project follows a clean, separated architecture where every concern lives in its own dedicated folder:
plain
Copy
UniversityManagementSystem/
│
├── 📂 Models/                    ← 62+ domain model classes
│   ├── BaseModel.cs              ← Id, IsActive, CreatedAt, UpdatedAt, DeletedAt
│   ├── University.cs
│   ├── Campus.cs
│   ├── Student.cs
│   └── ... (all models)
│
├── 📂 Database/
│   └── LibraryDbContext.cs       ← EF Core DbContext with all DbSets & Fluent API
│
├── 📂 DTOs/
│   ├── ApiResponse.cs            ← Generic { success, message, data } wrapper
│   └── AllDtos.cs                ← Read & Create DTOs for every model
│
├── 📂 Services/
│   ├── 📂 Interfaces/
│   │   └── IGenericService.cs    ← CRUD interface
│   └── GenericService.cs         ← Generic implementation (soft-delete, timestamps)
│
├── 📂 Controllers/               ← 61 API controllers (one per model)
│   ├── UniversityController.cs
│   ├── CampusController.cs
│   └── ... (61 total)
│
├── 📂 Properties/
│   └── launchSettings.json
│
├── appsettings.json              ← Connection string
├── appsettings.Development.json
├── Program.cs                    ← Auto-migration + Swagger at root
└── UniversityManagementSystem.csproj
Every Model Exposes These 5 Endpoints
Table
Method	URL Pattern	Action
GET	/api/{Model}	Retrieve all active records
GET	/api/{Model}/{id}	Retrieve single record by ID
POST	/api/{Model}	Create a new record
PUT	/api/{Model}/{id}	Update an existing record
DELETE	/api/{Model}/{id}	Soft-delete a record (sets IsActive = false)
🚀 Getting Started
Prerequisites
Make sure the following are installed on your machine before proceeding:
✅ .NET 8 SDK
✅ Microsoft SQL Server 2019 or later (Express edition is supported)
✅ Visual Studio 2022 or VS Code with the C# extension
✅ SQL Server Management Studio (SSMS) — optional, for DB inspection
✅ Git — for cloning the repository
Step 1 — Clone the Repository
bash
Copy
git clone https://github.com/your-username/UniversityManagementSystem.git
cd UniversityManagementSystem
Step 2 — Configure the Connection String
Open appsettings.json and update the SqlConnection value to point to your SQL Server instance:
JSON
Copy
{
  "ConnectionStrings": {
    "SqlConnection": "Server=YOUR_SERVER_NAME\SQLEXPRESS;
                       Database=UMS;
                       Integrated Security=true;
                       TrustServerCertificate=True"
  }
}
🔹 Replace YOUR_SERVER_NAME with your actual SQL Server host name.
Step 3 — Apply Migrations & Create Database
Run the following commands in the project root to scaffold and apply the initial migration:
bash
Copy
# Restore all NuGet packages
dotnet restore

# Create the initial EF Core migration
dotnet ef migrations add InitialCreate

# Apply migration to the database (creates DB if it does not exist)
dotnet ef database update
💡 Note: The application also auto-migrates on startup via db.Database.Migrate() in Program.cs, so this step can be skipped on subsequent runs.
Step 4 — Run the Application
bash
Copy
dotnet run
# Or with hot reload during development
dotnet watch run
Once running, open your browser and navigate to:
Table
URL	Description
http://localhost:5000	🌐 Swagger UI (interactive API docs)
http://localhost:5000/api/University	📡 Example API endpoint
📊 Database Schema Overview
The UMS database is organized into logical modules. Each table inherits from BaseModel which provides Id, IsActive, CreatedBy, CreatedAt, UpdatedBy, UpdatedAt, DeletedBy, and DeletedAt columns automatically.
🏛️ Core Academic Structure
Table
Table / Entity	Key Fields	Relationships
University	Id, Name, Code, Description	1 → Many Campuses
Campus	Id, Name, Code, UniversityId	1 → Many Blocks, Faculties
Faculty	Id, Name, Code, CampusId, EstablishedIn	1 → Many Institutes
Institute	Id, Name, Code, FacultyId	1 → Many Departments
Department	Id, Name, Code, InstituteId	Self-ref: SubDepartments
Block	Id, Name, Code, CampusId	1 → Many Buildings
Building	Id, Name, Code, BlockId	1 → Many Floors
Floor	Id, Name, Code, BuildingId	1 → Many Rooms
Room	Id, Name, Code, FloorId, EstablishedIn	Has RoomType & Features
👥 People & HR
Table
Table / Entity	Key Fields	Relationships
Party	Id, PartyName, PartyContact, PartyTypeId	1 → Many Members, Students
Student	Id, RegistrationNumber, PartyId, DegreeProgramId	FK → Party
Employee	Id, Name, Code, JoiningDate, LeavingDate	1 → Many RelationHistories
EmployeeRelationHistory	Id, EmployeeId, DesignationId, DepartmentId, IsCurrent	FK → Employee, Dept, Desig
Designation	Id, Name, Code	1 → Many RelationHistories
Position	Id, Category, Code	1 → Many Parties
📚 Library & Circulation
Table
Table / Entity	Key Fields	Relationships
LibraryBranch	Id, LibraryTypeId, ParentId, Description	1 → Many Members, Copies
LibraryMember	Id, CardNo, LibraryBranchId, PartyId, MembershipType	1 → Many Issuances, Fines
ItemInfo	Id, Title, ISBN, SubjectHeadingId, Keywords	1 → Many Copies, Editions
ItemCopy	Id, ItemInfoId, Barcode, AccessionNumber, UnitCost	FK → Branch, Section, Rack, Shelf
Issuance	Id, LibraryMemberId, ItemCopyId, DurationId, IssueDate	Tracks active loans
ReturnItem	Id, IssuanceId, LibraryItemId, ReturnDate	FK → Issuance, ItemCopy
ReserveItem	Id, ItemInfoId, LibraryMemberId, ExpiryDate	Advance reservations
CirculationRule	Id, PartyId, MaxCurrentLoans, LoanDays, OverdueFine	Per member-type policies
💰 Fines & Finance
Table
Table / Entity	Key Fields	Relationships
FineCategory	Id, FineCategoryName	1 → Many FineDefinitions
FineDefinition	Id, FineConditionId, ItemCopyId	FK → FineCategory, ItemCopy
UserFine	Id, LibraryMemberId, FineDefinitionId, FineAccrued	FK → Member, FineDefinition
FineTransaction	Id, FineAllocationId, Amount, PaidOn, PaymentRef	Payment records
AcquisitionRecord	Id, Type, PartyId, Invoice, Date, Amount	Purchase acquisition log
ItemQuotation	Id, PartyId, LibraryRackId, Amount, Discount	Vendor quotations
PurchaseItem	Id, ItemQuotationId, PartyId, TotalAmount, Discount	Final purchase records
🔌 API Endpoints
Authentication
🔒 Coming Soon: JWT Bearer Authentication
University Controller
plain
Copy
GET    /api/University              → Get all universities
GET    /api/University/{id}         → Get university by ID
POST   /api/University              → Create new university
PUT    /api/University/{id}         → Update university
DELETE /api/University/{id}         → Soft delete university
Student Controller
plain
Copy
GET    /api/Student                 → Get all students
GET    /api/Student/{id}            → Get student by ID
POST   /api/Student                 → Register new student
PUT    /api/Student/{id}            → Update student record
DELETE /api/Student/{id}            → Soft delete student
Employee Controller
plain
Copy
GET    /api/Employee                → Get all employees
GET    /api/Employee/{id}           → Get employee by ID
POST   /api/Employee                → Add new employee
PUT    /api/Employee/{id}           → Update employee
DELETE /api/Employee/{id}           → Soft delete employee
📄 All 61 controllers follow the same pattern. See Swagger UI for complete documentation.
⚙️ EF Core Commands Reference
Use these commands from the project root directory (where the .csproj file is located):
Table
Command	Description
dotnet ef migrations add <Name>	Create a new migration with the given name
dotnet ef database update	Apply all pending migrations to the database
dotnet ef database drop	Drop the entire database (use with caution)
dotnet ef migrations remove	Remove the last unapplied migration
dotnet ef migrations list	List all migrations and their applied status
dotnet ef dbcontext info	Display DbContext configuration info
dotnet ef dbcontext scaffold ...	Reverse-engineer models from an existing database
dotnet ef database update 0	Roll back all migrations (reset to empty schema)
dotnet ef database update <Name>	Roll forward or back to a specific migration
💡 Tip: If you get a build error running EF commands, run dotnet build first to ensure the project compiles cleanly.
💻 Sample Code
Generic Service (Services/GenericService.cs)
The GenericService handles all CRUD operations with soft-delete and automatic timestamp management:
csharp
Copy
public class GenericService<TEntity> : IGenericService<TEntity>
    where TEntity : BaseModel
{
    private readonly LibraryDbContext _context;
    private readonly DbSet<TEntity> _dbSet;

    public GenericService(LibraryDbContext context)
    {
        _context = context;
        _dbSet = context.Set<TEntity>();
    }

    // Returns only active (non-deleted) records
    public async Task<IEnumerable<TEntity>> GetAllAsync()
        => await _dbSet.Where(e => e.IsActive).ToListAsync();

    // Soft delete — never hard deletes
    public async Task<bool> DeleteAsync(int id)
    {
        var entity = await _dbSet
            .FirstOrDefaultAsync(e => e.Id == id && e.IsActive);

        if (entity == null) return false;

        entity.IsActive = false;
        entity.DeletedAt = DateTime.UtcNow;
        entity.DeletedBy = "system";

        await _context.SaveChangesAsync();
        return true;
    }
}
Controller Pattern (Controllers/UniversityController.cs)
Every controller follows this standard pattern — clean, consistent, and self-documenting:
csharp
Copy
[ApiController]
[Route("api/[controller]")]
public class UniversityController : ControllerBase
{
    private readonly GenericService<University> _service;

    public UniversityController(LibraryDbContext context)
        => _service = new GenericService<University>(context);

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var items = await _service.GetAllAsync();
        var result = items.Select(e => new UniversityDto
        {
            Id = e.Id,
            Name = e.Name,
            Code = e.Code,
            Description = e.Description
        });

        return Ok(ApiResponse<IEnumerable<UniversityDto>>.Ok(result));
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateUniversityDto dto)
    {
        var entity = new University
        {
            Name = dto.Name,
            Code = dto.Code,
            Description = dto.Description
        };

        var created = await _service.CreateAsync(entity);

        return CreatedAtAction(
            nameof(GetById),
            new { id = created.Id },
            ApiResponse<UniversityDto>.Ok(
                new UniversityDto { Id = created.Id, Name = created.Name },
                "Created successfully."
            )
        );
    }
}
API Response Format
All endpoints return a consistent JSON envelope:
✅ Success Response
JSON
Copy
{
  "success": true,
  "message": "Success",
  "data": {
    "id": 1,
    "name": "University of Engineering & Technology",
    "code": "UET",
    "description": "Premier engineering university"
  }
}
❌ Error / Not Found Response
JSON
Copy
{
  "success": false,
  "message": "Record not found.",
  "data": null
}
Auto-Migration in Program.cs
The database is automatically migrated every time the application starts:
csharp
Copy
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider
        .GetRequiredService<LibraryDbContext>();

    try { db.Database.Migrate(); }
    catch (Exception ex)
    {
        var logger = scope.ServiceProvider
            .GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "Migration failed.");
    }
}
🤝 Contributing
Contributions are welcome! Please follow these steps to contribute to the project:
Fork the repository on GitHub.
Create a new feature branch:
bash
Copy
git checkout -b feature/your-feature-name
Make your changes following the existing code style and architecture.
Write clear commit messages describing what changed and why.
Push your branch to your fork:
bash
Copy
git push origin feature/your-feature-name
Open a Pull Request against the main branch with a description of your changes.
Code Style Guidelines
✅ Follow standard C# naming conventions (PascalCase for classes/methods, camelCase for locals)
✅ Every new model must have a corresponding DTO and Controller
✅ All controllers must use GenericService<T> — do not access DbContext directly in controllers
✅ Maintain the ApiResponse<T> wrapper for all endpoint responses
✅ Never hard-delete records — always set IsActive = false
✅ Add XML summary comments to public methods and controllers
Reporting Issues
Found a bug or want to request a feature? Open an issue on GitHub with:
📝 A clear title describing the problem or feature
🔄 Steps to reproduce (for bugs)
✅ Expected vs actual behaviour
💻 Your environment: OS, .NET version, SQL Server version
👤 Author
<div align="center">
🎓 University Management System
Built with ASP.NET Core 8 • Entity Framework Core • SQL Server

