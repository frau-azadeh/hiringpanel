#  Hiring Panel API

A simple and extensible Web API built with **ASP.NET Core** and **Entity Framework Core**, designed to manage job applicants.

![.NET](https://img.shields.io/badge/.NET-8.0-blue)

![EF Core](https://img.shields.io/badge/Entity%20Framework%20Core-8.0-green)

![License](https://img.shields.io/badge/license-MIT-blue.svg)

---

## 📋 Features

 🔹 View all applicants

 🔹 Add a new applicant

 🔹 Built with SQLite and EF Core

 🔹 Swagger UI for API testing

 🔹 Easily extendable for future hiring features

---

## 🏗️ Technologies Used

 [.NET 8.0](https://dotnet.microsoft.com/)

 [ASP.NET Core Minimal APIs](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/minimal-apis)

 [Entity Framework Core (EF Core)](https://learn.microsoft.com/en-us/ef/core/)

 [SQLite](https://www.sqlite.org/index.html)

 [Swagger (Swashbuckle)](https://github.com/domaindrivendev/Swashbuckle.AspNetCore)

---

## 🚀 Getting Started

### Prerequisites

    - [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)

    - Git

    - Optional: Visual Studio or VS Code

### 🔧 Setup Instructions

1. Clone the repository:

   git clone https://github.com/frau-azadeh/hiringpanel.git

   cd hiringpanel

2. Restore dependencies:

    dotnet restore

3. Apply EF Core migration:

    dotnet ef migrations add InitialCreate

    dotnet ef database update

4. Run the application:

    dotnet run

5. Open Swagger UI:

    http://localhost:5277/swagger

## 🗂️ Project Structure

```
├── Applicant.cs              # Applicant entity model
├── HiringPanelDbContext.cs   # EF Core DbContext
├── Program.cs                # Application startup and API endpoints
├── appsettings.json          # App configuration (e.g., DB connection)
├── Migrations/               # EF Core migrations
└── README.md                 # Project documentation
```

## 📃 License

This project is licensed under the MIT License.

See the LICENSE file for details.

## ✨ Future Improvements
Update & delete applicant endpoints

Admin dashboard

Resume upload

Interview tracking

## 🌻Developed by

Azadeh Sharifi Soltani



