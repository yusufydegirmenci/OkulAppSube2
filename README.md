# OkulAppSube2

![C#](https://img.shields.io/badge/C%23-ADO.NET%20%2B%20EF%20Core%208-512bd4) ![SQL Server](https://img.shields.io/badge/SQL%20Server-Express-cc2927) ![Windows Forms](https://img.shields.io/badge/UI-Windows%20Forms-0078d4)

Two small student-record practice projects for learning data access in C#:

- **OkulAppSube2** — Windows Forms app using plain ADO.NET (`SqlConnection`, parameterized queries), .NET Framework 4.7.2. Saves a student (name, surname, number) and highlights empty fields.
- **EfAppSube2** — console app using Entity Framework Core 8 (Code First) with SQL Server. Shows add / update / select / delete with commented examples in `program.cs`.

## Project structure
```
OkulAppSube2/   Windows Forms app (ADO.NET, .NET Framework 4.7.2)
EfAppSube2/     console app (EF Core 8, Code First)
Database.sql    creates OkulDbSube2 and the tblogrenciler table
```

## Setup
Requires Visual Studio (.NET desktop development) and SQL Server Express.

**Windows Forms app**
1. Run `Database.sql` in SQL Server Management Studio.
2. Adjust the connection string in `OkulAppSube2/Form1.cs` if your instance is not `.\SQLEXPRESS`.
3. Run `OkulAppSube2`.

**EF Core app**
1. Adjust the connection string in `EfAppSube2/OkulDbContext.cs` if needed.
2. Create the database:
   ```
   dotnet ef migrations add Initial --project EfAppSube2
   dotnet ef database update --project EfAppSube2
   ```
3. Run `EfAppSube2`.

## Notes
Learning project, not production code. Connection strings use Windows authentication, no credentials are stored.

## Author
Yusuf Yahya Değirmenci — [GitHub](https://github.com/yusufydegirmenci)
