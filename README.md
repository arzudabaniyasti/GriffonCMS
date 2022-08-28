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



