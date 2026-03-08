# Personal Information Management System

An ASP.NET MVC application for managing personal information records, built with .NET 9, Entity Framework Core, SQL Server, Bootstrap 5, and jQuery DataTables.

---

## Project Architecture

```
Controllers/
  PersonalInfoController.cs     ← Handles HTTP requests, uses IPersonalInfoService
Interfaces/
  IPersonalInfoService.cs       ← Service contract (interface)
Services/
  PersonalInfoService.cs        ← Business logic + EF Core DB operations
Models/
  PersonalInfo.cs               ← Entity model (10+ fields)
Data/
  AppDbContext.cs               ← EF Core DbContext
  SeedData.cs                   ← 1000 dummy records seeder
Views/
  PersonalInfo/
    Index.cshtml                ← DataTable list with search, sort, pagination
    Create.cshtml               ← Add new record form
    Edit.cshtml                 ← Update record form
    Delete.cshtml               ← Delete confirmation page
  Shared/
    _Layout.cshtml              ← Sidebar layout with Bootstrap 5
Program.cs                      ← DI registration, app pipeline
appsettings.json                ← Connection string config
```

**Request flow:** `Controller → IPersonalInfoService → PersonalInfoService → AppDbContext → SQL Server`

---

## Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (LocalDB, Express, or full)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) or VS Code

---

## Setup Instructions

### 1. Clone / Open the Project

```bash
git clone <repo-url>
cd Personal_Info_Management_System
```

### 2. Configure the Database Connection

Open `appsettings.json` and update the connection string:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=PersonalInfoDb;Trusted_Connection=True;MultipleActiveResultSets=true"
}
```

For SQL Server Express:
```json
"DefaultConnection": "Server=.\\SQLEXPRESS;Database=PersonalInfoDb;Trusted_Connection=True;"
```

For full SQL Server with credentials:
```json
"DefaultConnection": "Server=YOUR_SERVER;Database=PersonalInfoDb;User Id=sa;Password=YOUR_PASSWORD;"
```

### 3. Apply Migrations & Seed Data

The application automatically runs migrations and seeds 1000 records on first startup via `Program.cs`.

To manually run migrations:

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

### 4. Run the Application

```bash
dotnet run
```

Or press **F5** in Visual Studio.

Navigate to: `https://localhost:5001` or `http://localhost:5000`

---

## Features

| Feature | Details |
|---|---|
| **Architecture** | Service Layer + Interface + Dependency Injection |
| **CRUD** | Create, Read, Update, Delete with confirmation |
| **DataTables** | Pagination, search, sorting (1000 records) |
| **Seed Data** | 1000 auto-generated dummy records |
| **Validation** | Server-side (Data Annotations) + Client-side (jQuery Validate) |
| **UI** | Bootstrap 5, sidebar layout, responsive |
| **Bonus** | DI, Repository-style service, clean UI, AJAX DataTable |

---

## NuGet Packages Required

```xml
<PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="9.0.13" />
<PackageReference Include="Microsoft.EntityFrameworkCore.Tools" Version="9.0.13" />
<PackageReference Include="Microsoft.EntityFrameworkCore.Design" Version="9.0.13" />
```

Install via Package Manager:
```bash
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.EntityFrameworkCore.Design
```

---

## Pages

| Route | Description |
|---|---|
| `/PersonalInfo` | Main list with DataTable |
| `/PersonalInfo/Create` | Add new record |
| `/PersonalInfo/Edit/{id}` | Edit existing record |
| `/PersonalInfo/Delete/{id}` | Delete confirmation |
| `/PersonalInfo/GetAll` | JSON endpoint for DataTable AJAX |

---

## Submitted By

Assignment for: **Zero Byte Software Solutions**  
Role: ASP.NET MVC Developer
