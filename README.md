"# dotnet-core-webapi" 
> [跟著保哥再一次學習 .NET core](https://blog.miniasp.com/post/2020/09/09/Create-Controller-and-Views-with-dotnet-aspnet-codegenerator) 

## Web api
```
dotnet new webapi -n project-name

dotnet tool update -g dotnet-ignore

dotnet ignore get -n visualstudio
```

## Entity framework core
```
dotnet tool update -g dotnet-ef

dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore.InMemory

dotnet ef dbcontext scaffold "Server=(localdb)\MSSQLLocalDB;Database=ContosoUniversity;Trusted_Connection=True;MultipleActiveResultSets=true" Microsoft.EntityFrameworkCore.SqlServer -o Models


```

## dotnet tools
```
dotnet tool install -g dotnet-aspnet-codegenerator


dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
```

### generate api controller / view
aspnet-codegenerator help
```
dotnet aspnet-codegenerator controller -h

Usage: aspnet-codegenerator [arguments] [options]

Arguments:
  generator  Name of the generator. Check available generators below.

Options:
  -p|--project             Path to .csproj file in the project.
  -n|--nuget-package-dir
  -c|--configuration       Configuration for the project (Possible values: Debug/ Release)
  -tfm|--target-framework  Target Framework to use. (Short folder name of the tfm. eg. net46)
  -b|--build-base-path
  --no-build

Selected Code Generator: controller

Generator Options:
  --controllerName|-name              : Name of the controller
  --useAsyncActions|-async            : Switch to indicate whether to generate async controller actions
  --noViews|-nv                       : Switch to indicate whether to generate CRUD views
  --restWithNoViews|-api              : Specify this switch to generate a Controller with REST style API, noViews is assumed and any view related options are ignored
  --readWriteActions|-actions         : Specify this switch to generate Controller with read/write actions when a Model class is not used
  --model|-m                          : Model class to use
  --dataContext|-dc                   : DbContext class to use
  --referenceScriptLibraries|-scripts : Switch to specify whether to reference script libraries in the generated views
  --layout|-l                         : Custom Layout page to use
  --useDefaultLayout|-udl             : Switch to specify that default layout should be used for the views
  --force|-f                          : Use this option to overwrite existing files
  --relativeFolderPath|-outDir        : Specify the relative output folder path from project where the file needs to be generated, if not specified, file will be generated in the project folder
  --controllerNamespace|-namespace    : Specify the name of the namespace to use for the generated controller
  --useSqlite|-sqlite                 : Flag to specify if DbContext should use SQLite instead of SQL Server.
```

api controller
```
dotnet aspnet-codegenerator controller -name CoursesController -async -api -m Course -dc ContosoUniversityContext -outDir Controllers
```

view controller without layout
```
dotnet aspnet-codegenerator controller -name DepartmentsController -async -scripts -udl -m Department -dc ContosoUniversityContext -outDir Controllers
```

controller no Views
```
dotnet aspnet-codegenerator controller -name DepartmentsController -async -nv -m Department -dc ContosoUniversityContext -outDir Controllers -f
```

Microsoft.AspNetCore.Identity.UI
```
dotnet add package Microsoft.AspNetCore.Identity.UI
dotnet aspnet-codegenerator identity -h
dotnet aspnet-codegenerator identity --useDefaultUI --dbContext ApiIdentityContext
dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore
```