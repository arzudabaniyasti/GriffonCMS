# GriffonCMS

## Initial Flow
```
dotnet clean
dotnet restore
dotnet build
```
---
## Setup Database
**Package Manager Console:**
```
EntityFrameworkCore\Update-Database
```
**cli:**
```
dotnet ef database update
```

---
## Add Migration
**Package Manager Console:**
```
EntityFrameworkCore\add-migration [migrationName]
```
**cli:**
```
dotnet ef migrations add [migrationName]
```

## Architecture Summary
The system was built with N-Tier Architecture and Domain Driven Design (DDD) was adopted.

GriffonCMS.Core
- The database is the access layer.
    - DBContext
    - Repositories

GriffonCMS.Application
- Business Logic
    - MediatR

GriffonCMS.Domain
- It is the layer where domain separation is provided.
    - Entities
    - Repository Interfaces

GriffonCMS.Infrastructure
- All infrastructure adjustments that the application will need are made in this layer.
    - IRequest Objects
    - DTOS
    - Options
    - AutoMapper Profiles
    - Registrations
    - ...

GriffonCMS.WebUI
- It is the layer where only Interface related operations are applied.
    - Contollers



