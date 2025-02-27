# 📌 Project Name

This project is built using the **Onion CQRS architecture** while following **SOLID principles**. It leverages **ASP.NET Core**, **Entity Framework Core**, and **MediatR** for handling requests and business logic.

## 🚀 Technologies Used

The project utilizes the following NuGet packages:

```xml
<PackageReference Include="Microsoft.EntityFrameworkCore" Version="8.0.8" />
<PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="8.0.8" />
<PackageReference Include="Microsoft.EntityFrameworkCore.Tools" Version="8.0.8" />
<PackageReference Include="AutoMapper.Extensions.Microsoft.DependencyInjection" Version="12.0.0" />
<PackageReference Include="MediatR" Version="12.4.1" />
<PackageReference Include="Microsoft.AspNetCore.OpenApi" Version="8.0.6" />
<PackageReference Include="Microsoft.VisualStudio.Web.CodeGeneration.Design" Version="8.0.7" />
<PackageReference Include="Swashbuckle.AspNetCore" Version="6.4.0" />
```

## 🏗️ Architecture

The project follows the **Onion Architecture**, ensuring separation of concerns and maintainability:

- **Core Layer** → Contains entities and business logic.
- **Application Layer** → Handles commands/queries using **MediatR**.
- **Infrastructure Layer** → Handles database access via **EF Core**.
- **API Layer** → Exposes endpoints via **ASP.NET Core Web API**.

## 📌 Features

- ✅ **CQRS with MediatR** for better separation of concerns.
- ✅ **EF Core** for data persistence.
- ✅ **Dependency Injection** using Microsoft.Extensions.
- ✅ **SOLID Principles** for maintainability.

## 💡 Contribution

Feel free to fork, open issues, or submit PRs if you find improvements! 🚀

