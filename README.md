# Student CRUD Application - README

## How to Run the Project

Follow these steps to run the project on your system:

1. **Install required NuGet packages**
   ```bash
   dotnet add package Microsoft.EntityFrameworkCore.Design --version 9.0.0
   dotnet add package Microsoft.EntityFrameworkCore --version 9.0.0
   dotnet add package Microsoft.EntityFrameworkCore.Relational --version 9.0.0
   dotnet add package Microsoft.EntityFrameworkCore.Tools --version 9.0.0
   dotnet add package Pomelo.EntityFrameworkCore.MySql --version 9.0.0
   ```

2. **Create database migrations**
   ```bash
   dotnet ef migrations add InitialCreate
   ```

3. **Update the database**
   ```bash
   dotnet ef database update
   ```

4. **Run the application**
   ```bash
   dotnet run
   ```

5. **Open in browser**
   ```
   http://localhost:5003
   ```

---

## Technologies Used

- .NET 10 / ASP.NET Core MVC
- Entity Framework Core 9
- Pomelo MySQL Provider 9
- MySQL Database 
- Bootstrap
- C#

--

## Assumptions & Limitations

### Assumptions
- User has MySQL installed and running locally.
- The connection string in `appsettings.json` is correct.
- The Student table structure matches the EF Core `Students` model.
- ASP.NET Core MVC knowledge is basic but sufficient to understand controllers and views.

### Limitations
- anyone can access CRUD pages.
- No pagination for student list .
- Basic validation only .
- Works only with MySQL .





