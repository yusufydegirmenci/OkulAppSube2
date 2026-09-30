# OkulAppSube2

Two small student-record practice apps, written while learning data access in C#:

- **OkulAppSube2** — Windows Forms app using plain ADO.NET (`SqlConnection`), .NET Framework 4.7.2
- **EfAppSube2** — console app using Entity Framework Core 8 (Code First) with SQL Server

## Status
Work in progress / learning project. The EF Core model (`Ogrenci`) is still being cleaned up, and the CRUD examples in `program.cs` are commented out for experimenting.

## Run
1. Install Visual Studio with .NET desktop development and SQL Server Express.
2. Adjust the connection strings in `OkulAppSube2/Form1.cs` and `EfAppSube2/OkulDbContext.cs` for your machine.
3. Open `OkulAppSube2.sln` and run.

## Author
Yusuf Yahya Değirmenci — [GitHub](https://github.com/23380101076)
