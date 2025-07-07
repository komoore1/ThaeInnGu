# ThaeInnGu

A .NET MAUI (MVVM + DDD) desktop app with Azure SQL backend.

## Structure
- `MyApp.Domain` – business logic
- `MyApp.Application` – use cases
- `MyApp.Infrastructure` – EF Core / DB implementations
- `APP` – .NET MAUI UI
- `*.Tests` – xUnit unit tests

## Requirements
- .NET 8 SDK
- SQL Server (local or Docker/Azure)
