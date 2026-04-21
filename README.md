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
The project follows a clean, separated architecture where every concern lives in its own dedicated folder:
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
git clone https://github.com/your-username/UniversityManagementSystem.git
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
 Run the following commands in the project root to scaffold and apply the initial migration:

# Restore all NuGet packages
dotnet restore

# Create the initial EF Core migration
dotnet ef migrations add InitialCreate

# Apply migration to the database (creates DB if it does not exist)
dotnet ef database update
 Note: The application also auto-migrates on startup via db.Database.Migrate() in Program.cs, so this step can be skipped on subsequent runs.

**Run the Application**
dotnet run
# Or with hot reload during development
dotnet watch run

| URL                                    | Description                          |
| -------------------------------------- | ------------------------------------ |
| `http://localhost:5000`                | 🌐 Swagger UI (interactive API docs) |
| `http://localhost:5000/api/University` | 📡 Example API endpoint              |



 

