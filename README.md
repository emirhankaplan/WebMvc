# 🍽️ WebMvc — Restaurant Menu Manager (ASP.NET Core MVC)

An **ASP.NET Core MVC (.NET 8)** application for managing a restaurant menu: dishes (*Yemek*) and dish categories (*Yemek Türü*) with full CRUD, built on **Entity Framework Core** and **SQL Server** using the repository pattern.

## ✨ Features

- **Dish categories** — list, add, update and delete (name is required, max. 25 characters)
- **Dishes** — list, add, update and delete with name, description and price (validated between 10 and 2000)
- Validation messages and success notifications (TempData)
- Generic repository (`IRepository<T>`) plus specific repositories, registered through dependency injection
- EF Core code-first migrations

## 🧰 Tech stack

ASP.NET Core MVC · .NET 8 · Entity Framework Core 8 · SQL Server · Razor views · Bootstrap

## 📁 Project structure

```text
Web Mvc/
├── Controllers/   # HomeController, YemekController, YemekTuruController
├── Models/        # Yemek, YemekTuru, IRepository<T> / Repository<T>, specific repositories
├── Utility/       # UygulamaDbContext (EF Core)
├── Migrations/    # EF Core migrations
└── Views/         # Yemek, YemekTuru, Home, Shared
```

## 🚀 Getting started

**Prerequisites:** [.NET 8 SDK](https://dotnet.microsoft.com/download) and SQL Server.

1. Set `ConnectionStrings:DefaultConnection` in `Web Mvc/appsettings.json` to your SQL Server instance.
2. Create the database:

   ```bash
   cd "Web Mvc"
   dotnet ef database update
   ```

3. Run the app:

   ```bash
   dotnet run
   ```

4. Manage categories at `/YemekTuru` and dishes at `/Yemek`.
