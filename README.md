# UniversityDbApp

ASP.NET Core (.NET 10) + Entity Framework Core + MS SQL Server. 3-апта: ORM, DbContext, Code-First миграциялары.

## Құрамы

**Тапсырма (Assignment)**
- `Models/Department.cs`, `Models/Teacher.cs` (1-to-N, Foreign Key `DepartmentId`)

**Зертханалық жұмыс (Lab)**
- `Models/Category.cs`, `Models/Product.cs` (1-to-N, Foreign Key `CategoryId`)

**Ортақ**
- `Data/AppDbContext.cs` (DbContext, DbSet, бастапқы деректер)
- `Program.cs` (DbContext тіркеу)
- `appsettings.json` (Connection String)
- `Migrations/` (`InitialDb` миграциясы)

## Іске қосу

1. `UniversityDbApp.sln` файлын Visual Studio-да ашыңыз.
2. `appsettings.json` ішінде `Server=` мәнін өз SQL Server атауыңызға сәйкестендіріңіз.
3. Package Manager Console:

```
Update-Database
```

4. `F5`: браузерде кафедралар мен оқытушылар тізімі шығады.
