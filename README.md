"# dotnet-core-webapi" 

## Web api
> dotnet new webapi -n project-name

> dotnet tool update -g dotnet-ignore

> dotnet ignore get -n visualstudio

## Entity framework core
> dotnet tool update -g dotnet-ef

```
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore.InMemory

dotnet ef dbcontext scaffold "Server=(localdb)\MSSQLLocalDB;Database=ContosoUniversity;Trusted_Connection=True;MultipleActiveResultSets=true" Microsoft.EntityFrameworkCore.SqlServer -o Models


```

## dotnet tools

> dotnet tool install -g dotnet-aspnet-codegenerator

```
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
```