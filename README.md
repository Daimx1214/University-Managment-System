**University Management System — .NET & EF Core**
A console-based **University Management System** built with C# (.NET) and **Entity Framework Core**, implementing a fully normalized relational database schema via code-first migrations. Features advanced LINQ operations, repository-pattern data access, and complex entity relationships spanning students, instructors, academic departments, course catalogs, and enrollment records.

**Features**
The University Management System provides a full-suite REST API covering every dimension of university operations. Each module is implemented as a dedicated controller with complete CRUD support.

| Feature                      | Description                                                             | Endpoint                  |
| ---------------------------- | ----------------------------------------------------------------------- | ------------------------- |
| 🏛️ **Academic Setup**       | Manage universities, campuses, faculties, institutes & departments      | `/api/University`         |
| 👨‍🎓 **Student Management** | Student registration, enrollment, program & session tracking            | `/api/Student`            |
| 👔 **Employee & HR**         | Employee records, designations, relation histories & payroll structures | `/api/Employee`           |
| 📚 **Library System**        | Books, copies, issuances, reservations, returns & fine management       | `/api/ItemInfo`           |
| 📋 **Circulation Rules**     | Configure loan limits, grace days, overdue fines per member type        | `/api/CirculationRule`    |
| 💰 **Fine Management**       | Fine categories, definitions, user fines & payment transactions         | `/api/UserFine`           |
| 🛒 **Acquisitions**          | Item quotations, purchase orders & acquisition records                  | `/api/PurchaseItem`       |
| 🏢 **Physical Structure**    | Buildings, blocks, floors, rooms, room types & feature allocations      | `/api/Building`           |
| 🔢 **Accession Control**     | Accession number patterns per branch for systematic item cataloguing    | `/api/AccessionPattern`   |
| 📦 **Item Conditions**       | Track physical condition & remarks for every item copy                  | `/api/ItemCondition`      |
| 📄 **Requisitions**          | Library & item requisition workflows with employee approval chain       | `/api/LibraryRequisition` |
| 🗑️ **Withdrawals**          | Withdraw damaged or decommissioned item copies with audit trail         | `/api/Withdrawal`         |
| 🛡️ **Soft Delete**          | All records are soft-deleted (`IsActive` flag) — no data loss ever      | All endpoints             |
| ⏰ **Auto Timestamps**        | `CreatedAt`, `UpdatedAt`, `DeletedAt` auto-populated on every operation | All endpoints             |
| 📖 **Swagger UI**            | Interactive API documentation available at application root             | `/`                       |
| 🔄 **Auto Migration**        | Database schema applied automatically on every application startup      | `Program.cs`              |

**Tech Stack**
| Layer                 | Technology                   | Version             |
| --------------------- | ---------------------------- | ------------------- |
| **Framework**         | ASP.NET Core                 | 8.0 (`net8.0`)      |
| **Language**          | C#                           | 12.0                |
| **ORM**               | Entity Framework Core        | 8.0.0               |
| **Database**          | Microsoft SQL Server         | 2019 / 2022         |
| **DB Driver**         | Microsoft.Data.SqlClient     | EF bundled          |
| **API Documentation** | Swashbuckle / Swagger UI     | 6.6.2               |
| **Architecture**      | REST Web API (MVC)           | Controller-based    |
| **Pattern**           | Repository / Service Layer   | `GenericService<T>` |
| **Response Format**   | JSON (`ApiResponse` wrapper) | Custom              |
| **Delete Strategy**   | Soft Delete (`IsActive`)     | Custom `BaseModel`  |

**Project Structure**
UniversityManagmentSystem/
│
├── Models/                        # Entity classes
│   ├── Student.cs
│   ├── Teacher.cs
│   ├── Course.cs
│   ├── Department.cs
│   └── Enrollment.cs
│
├── Data/                          # EF Core DbContext
│   └── UniversityDbContext.cs
│
├── Migrations/                    # Auto-generated EF Core migrations
│
├── Program.cs                     # Application entry point & menu logic
│
└── UniversityManagmentSystem.csproj

**Every Model Exposes These 5 Endpoints**
| Method     | URL Pattern         | Action                                         |
| ---------- | ------------------- | ---------------------------------------------- |
| **GET**    | `/api/{Model}`      | Retrieve all active records                    |
| **GET**    | `/api/{Model}/{id}` | Retrieve single record by ID                   |
| **POST**   | `/api/{Model}`      | Create a new record                            |
| **PUT**    | `/api/{Model}/{id}` | Update an existing record                      |
| **DELETE** | `/api/{Model}/{id}` | Soft-delete a record (sets `IsActive = false`) |

**Getting Started**

**Prerequisites**
Make sure the following are installed on your machine before proceeding:
✅ .NET 8 SDK
✅ Microsoft SQL Server 2019 or later (Express edition is supported)
✅ Visual Studio 2022 or VS Code with the C# extension
✅ SQL Server Management Studio (SSMS) — optional, for DB inspection
✅ Git — for cloning the repository

**Clone the Repository**
git clone https://github.com/Daimx1214/UniversityManagementSystem.git
cd UniversityManagementSystem

**Configure the Connection String**
Open appsettings.json and update the SqlConnection value to point to your SQL Server instance:
{

  "ConnectionStrings": {
    "SqlConnection": "Server=LAPTOP-VACOCRFI;
                       Database=UMS;
                       Integrated Security=true;
                       TrustServerCertificate=True"
  }
}

 **Apply Migrations & Create Database**
dotnet ef migrations add InitialCreate
dotnet ef database update
**Restore all NuGet packages**
dotnet restore
**Create the initial EF Core migration**
dotnet ef migrations add InitialCreate
dotnet ef database update
**Apply migration to the database (creates DB if it does not exist)**
dotnet ef database update
 Note: The application also auto-migrates on startup via db.Database.Migrate() in Program.cs, so this step can be skipped on subsequent runs.
**Run the Application**
dotnet run --project UniversityManagmentSystem
**Or with hot reload during development**
dotnet watch run

| URL                                    | Description                          |
| -------------------------------------- | ------------------------------------ |
| `http://localhost:5000`                | 🌐 Swagger UI (interactive API docs) |
| `http://localhost:5000/api/University` | 📡 Example API endpoint              |

**Database Schema Overview**
The UMS database is organized into logical modules. Each table inherits from BaseModel which provides Id, IsActive, CreatedBy, CreatedAt, UpdatedBy, UpdatedAt, DeletedBy, and DeletedAt columns automatically.
**🏛️ Core Academic Structure**

 | Table / Entity | Key Fields                                        | Relationships              |
| -------------- | ------------------------------------------------- | -------------------------- |
| **University** | `Id`, `Name`, `Code`, `Description`               | 1 → Many Campuses          |
| **Campus**     | `Id`, `Name`, `Code`, `UniversityId`              | 1 → Many Blocks, Faculties |
| **Faculty**    | `Id`, `Name`, `Code`, `CampusId`, `EstablishedIn` | 1 → Many Institutes        |
| **Institute**  | `Id`, `Name`, `Code`, `FacultyId`                 | 1 → Many Departments       |
| **Department** | `Id`, `Name`, `Code`, `InstituteId`               | Self-ref: SubDepartments   |
| **Block**      | `Id`, `Name`, `Code`, `CampusId`                  | 1 → Many Buildings         |
| **Building**   | `Id`, `Name`, `Code`, `BlockId`                   | 1 → Many Floors            |
| **Floor**      | `Id`, `Name`, `Code`, `BuildingId`                | 1 → Many Rooms             |
| **Room**       | `Id`, `Name`, `Code`, `FloorId`, `EstablishedIn`  | Has RoomType & Features    |

**API Endpoints**
**Authentication**
🔒 Coming Soon: JWT Bearer Authentication

**University Controller**
GET    /api/University              → Get all universities
GET    /api/University/{id}         → Get university by ID
POST   /api/University              → Create new university
PUT    /api/University/{id}         → Update university
DELETE /api/University/{id}         → Soft delete university

**EF Core Commands Reference**

| Command                            | Description                                       |
| ---------------------------------- | ------------------------------------------------- |
| `dotnet ef migrations add <Name>`  | Create a new migration with the given name        |
| `dotnet ef database update`        | Apply all pending migrations to the database      |
| `dotnet ef database drop`          | Drop the entire database *(use with caution)*     |
| `dotnet ef migrations remove`      | Remove the last unapplied migration               |
| `dotnet ef migrations list`        | List all migrations and their applied status      |
| `dotnet ef dbcontext info`         | Display DbContext configuration info              |
| `dotnet ef dbcontext scaffold ...` | Reverse-engineer models from an existing database |
| `dotnet ef database update 0`      | Roll back all migrations (reset to empty schema)  |
| `dotnet ef database update <Name>` | Roll forward or back to a specific migration      |

**Sample Code**
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

**Contributing**
Pull requests are welcome! For major changes, please open an issue first to discuss what you would like to change.

Fork the repository
Create your feature branch: git checkout -b feature/YourFeature
Commit your changes: git commit -m 'Add YourFeature'
Push to the branch: git push origin feature/YourFeature
Open a Pull Request

**Author**
Daim GitHub: @Daimx1214
