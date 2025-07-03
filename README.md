# CrsTakipSistemi

A task and training management system developed using **ASP.NET MVC** and **MySQL**.  
This project is designed for managing users, assigning tasks, and tracking training histories in a corporate environment.

---

## 🔧 Technologies Used

- ASP.NET MVC (Framework 4.8)
- Entity Framework 6
- MySQL
- Razor Views (HTML5 / CSS3)
- Visual Studio 2022

---

## 📁 Features

- User Management (Admin & Staff roles)
- Task Assignment & Status Tracking
- Training History Module
- Birthday Reminder View
- Role-Based Structure
- Form Validation (via Data Annotations)
- Relational Database Design

---

## 📦 NuGet Packages Installed

The following NuGet packages have been installed:

- `EntityFramework`
- `MySql.Data`
- `MySql.Data.EntityFramework`
- `Microsoft.CodeDom.Providers.DotNetCompilerPlatform`
- `Microsoft.AspNet.Mvc` *(included by default)*

---

## 🔗 Database Connection

Update your `Web.config` file with the following connection string:

```xml
<connectionStrings>
  <add name="DefaultConnection"
       connectionString="server=localhost;user id=root;password=yourPassword;database=crs_takip_db;"
       providerName="MySql.Data.MySqlClient" />
</connectionStrings>

⚠️ Make sure that crs_takip_db exists in your MySQL server.

🚀 Getting Started
Clone the project or download it.

Open the solution using Visual Studio 2022.

Restore NuGet packages if not done automatically.

Ensure MySQL is running and crs_takip_db database is created.

Build and run the project (Ctrl + F5).

🐙 GitHub Repository
Hosted on GitHub: github.com/OmerTuregun/tracking_system

👤 Author
Developed by OmerTuregun

