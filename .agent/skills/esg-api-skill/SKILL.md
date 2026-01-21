---
name: esg-api-skill
description: A skill for working with the ESG MCP API, a .NET 8 application for managing ESG data.
---

# ESG MCP API Skill

This skill provides context and instructions for working with the `esg-mcp-api` project.

## Project Overview

- **Type:** ASP.NET Core Web API (.NET 8)
- **Database:** SQL Server (LocalDB/Express)
    - **Connection String:** `Server=localhost\SQLEXPRESS;Database=dbHCIS;Integrated Security=True;TrustServerCertificate=True;`
- **ORM:** Entity Framework Core (EF Core)
- **Auth:** Windows Authentication (Integrated Security)

## Key Locations

- **Project File:** `esg-mcp-api.csproj`
- **Db Context:** `Data/DbHcisContext.cs`
- **Models:** `Data/*.cs` (e.g., `EsgGhGa.cs`, `Bauser.cs`)
- **Controllers:** `Controllers/*.cs` (e.g., `ContactController.cs`)

## Common Tasks

### 1. Database Operations

The project uses EF Core. `DbHcisContext` is the main entry point.

**Example: Querying ESG Data (e.g., Greenhouse Gas)**

```csharp
// In a Controller or Service
public async Task<IActionResult> GetGhGaData(string orgCode, string year)
{
    var data = await _db.EsgGhGas
        .Where(x => x.OrgCode == orgCode && x.CYear == year)
        .ToListAsync();
    return Ok(data);
}
```

**Example: Joining Users and Contacts**

See `ContactController.cs` for an example of joining `Bausers` and `MaiAgentContacts`.

```csharp
var users = await _db.Bausers.ToListAsync();
var contacts = await _db.MaiAgentContacts.ToListAsync();
var result = users.GroupJoin(contacts, ...);
```

### 2. Running the Project

```powershell
dotnet run --launch-profile https
```

### 3. Adding New Models

1.  Create a class in `Data/` (e.g., `EsgNewMetric.cs`).
2.  Add a `DbSet<EsgNewMetric>` to `Data/DbHcisContext.cs`.
3.  Add migration (if code-first) or update logic.

## Common Issues

- **Connection Errors:** Ensure SQL Server Express is running and `dbHCIS` database exists. Integated Security requires running as a user with DB access.
- **EF Core Tools:** If `dotnet ef` commands fail, ensure `Microsoft.EntityFrameworkCore.Tools` is installed (it is in `.csproj`).

## Project-Specific Logic

- **Organization Code (`OrgCode`)**: Key identifier for facilities/companies.
- **Year (`CYear`)**: String format (e.g., "2025") used for reporting periods.
