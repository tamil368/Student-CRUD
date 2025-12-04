# Student CRUD Application - README

## How to Run the Project

Follow these steps to run the project on your system:

1. **Install required packages**
2. -- cd crud
3. -- Open cmd And execute the following command's  
   ```bash
   dotnet add package Microsoft.EntityFrameworkCore.Design --version 9.0.0
   dotnet add package Microsoft.EntityFrameworkCore --version 9.0.0
   dotnet add package Microsoft.EntityFrameworkCore.Relational --version 9.0.0
   dotnet add package Microsoft.EntityFrameworkCore.Tools --version 9.0.0
   dotnet add package Pomelo.EntityFrameworkCore.MySql --version 9.0.0
   ```

4. **Create database migrations**
   ```bash
   dotnet ef migrations add InitialCreate
   ```

5. **Update the database**
   ```bash
   dotnet ef database update
   ```

6. **Run the application**
   ```bash
   dotnet run
   ```

7. **Edit the Db Configuration**
```bash
"DefaultConnection":"Server=127.0.0.1;Port=3307;Database=Students;Uid=root;Pwd=yourpassword;"
```



## Technologies Used

- .NET 10 / ASP.NET Core MVC
- Entity Framework Core 9
- Pomelo MySQL Provider 9
- MySQL Database 
- Bootstrap
- C#
  
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





