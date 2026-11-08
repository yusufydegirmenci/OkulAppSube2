# OkulAppSube2

![C#](https://img.shields.io/badge/C%23-.NET-512BD4?logo=dotnet&logoColor=white) ![ADO.NET](https://img.shields.io/badge/ADO.NET-.NET%20Framework%204.7.2-512BD4) ![EF Core](https://img.shields.io/badge/EF%20Core-8-512BD4) ![SQL Server](https://img.shields.io/badge/SQL%20Server-Express-CC2927?logo=microsoftsqlserver&logoColor=white)

**Contents:** [Projects](#projects) · [Structure](#structure) · [Setup](#setup) · [Troubleshooting](#troubleshooting) · [Notes](#notes)

## Projects

Two small student-record practice projects for learning data access in C#:

- **OkulAppSube2** — Windows Forms app using plain ADO.NET (`SqlConnection`, parameterized queries), .NET Framework 4.7.2. Saves a student (name, surname, number) and highlights empty fields.
- **EfAppSube2** — console app using Entity Framework Core 8 (Code First) with SQL Server. Shows add / update / select / delete with commented examples in `program.cs`.

## Structure

```
Database.sql         creates the database for the Windows Forms app
OkulAppSube2/        Windows Forms app (ADO.NET): Form1.cs holds the connection string
EfAppSube2/          console app (EF Core): OkulDbContext.cs, Ogrenci.cs, program.cs
OkulAppSube2.sln     open this in Visual Studio
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

## Troubleshooting

- **`dotnet ef` is not recognized:** install the tool once with `dotnet tool install --global dotnet-ef`, then open a new terminal.
- **"Cannot open database" / "A network-related error occurred":** SQL Server is not running or the instance name in the connection string is wrong. Check the server name in SQL Server Management Studio and copy it into the connection string. For LocalDB use `(localdb)\MSSQLLocalDB`.
- **The Windows Forms app cannot connect:** run `Database.sql` first, and make sure the instance name in `OkulAppSube2/Form1.cs` matches yours (default `.\SQLEXPRESS`).
- **Visual Studio cannot open the project:** install the ".NET desktop development" workload from the Visual Studio Installer.

## Notes
Learning project, not production code. Connection strings use Windows authentication, no credentials are stored.

## Author
Yusuf Yahya Değirmenci — [GitHub](https://github.com/yusufydegirmenci)
