# 📚 Learning Management System (LMS)

A modern, full-featured Learning Management System built with ASP.NET Core MVC that enables educational institutions to manage courses, instructors, trainees, and track educational progress efficiently.

## 🎯 Overview

This LMS platform provides a comprehensive solution for managing educational content and tracking student progress. The system supports multiple tracks, course enrollments, instructor assignments, and performance monitoring with a clean, maintainable architecture using the Repository pattern.

## ✨ Features

### Core Functionality
- **Course Management**: Create, update, and manage courses with detailed information including descriptions, pricing, seats, and grading criteria
- **Instructor Management**: Manage instructor profiles, assignments, salaries, and track associations
- **Trainee/Student Management**: Handle student enrollments, track progress, grades, and course completions
- **Track System**: Organize courses and students into specialized tracks for structured learning paths
- **User Authentication**: Secure login and registration system using ASP.NET Core Identity
- **Enrollment System**: Students can enroll in courses with seat capacity management
- **Grade Tracking**: Monitor and record student performance with minimum passing requirements

### Technical Features
- **Repository Pattern**: Clean separation of data access logic for maintainability
- **Entity Framework Core**: Modern ORM for database operations
- **SQL Server Integration**: Robust relational database support
- **MVC Architecture**: Separation of concerns with Model-View-Controller pattern
- **Responsive Design**: Bootstrap-based UI for cross-device compatibility

## 🛠️ Tech Stack

### Backend
- **Framework**: ASP.NET Core 8.0 (MVC)
- **Language**: C# (.NET 8.0)
- **ORM**: Entity Framework Core 8.0.8
- **Database**: Microsoft SQL Server
- **Authentication**: ASP.NET Core Identity 8.0.8

### Frontend
- **View Engine**: Razor Views
- **CSS Framework**: Bootstrap (included via wwwroot)
- **JavaScript**: jQuery with validation

### Architecture & Patterns
- **Repository Pattern**: For data access abstraction
- **Unit of Work Pattern**: For transaction management
- **Dependency Injection**: Built-in ASP.NET Core DI container
- **Three-tier Architecture**: Presentation (LMS) → Business Logic (Entities) → Data Access (DataAccess)

## 📋 Prerequisites

Before you begin, ensure you have the following installed:

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) or later
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (2019 or later) or SQL Server Express
- [Visual Studio 2022](https://visualstudio.microsoft.com/) (recommended) or Visual Studio Code
- [Git](https://git-scm.com/downloads)

## 🚀 Installation Instructions

### 1. Clone the Repository

```bash
git clone https://github.com/Moztafaa/LMS.git
cd LMS
```

### 2. Configure the Database Connection

Update the connection string in `LMS/appsettings.json`:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Data Source=YOUR_SERVER;Initial Catalog=LMS;User ID=YOUR_USERNAME;Password=YOUR_PASSWORD;Connect Timeout=30;Encrypt=False;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False"
  }
}
```

**Common SQL Server configurations:**

- **Windows Authentication**: `Data Source=localhost;Initial Catalog=LMS;Integrated Security=True;Trust Server Certificate=True`
- **SQL Server Express**: `Data Source=localhost\\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True;Trust Server Certificate=True`
- **Docker SQL Server**: `Data Source=localhost,1433;Initial Catalog=LMS;User ID=sa;Password=YourStrong@Passw0rd;Trust Server Certificate=True`

### 3. Restore Dependencies

```bash
dotnet restore
```

### 4. Apply Database Migrations

Navigate to the main LMS project directory and run:

```bash
cd LMS
dotnet ef database update
```

If you don't have Entity Framework CLI tools installed:

```bash
dotnet tool install --global dotnet-ef
```

### 5. Build the Solution

```bash
dotnet build
```

### 6. Run the Application

```bash
cd LMS
dotnet run
```

The application will start and be available at:
- HTTPS: `https://localhost:5001`
- HTTP: `http://localhost:5000`

## 💻 Usage

### Running the Application

1. **Start the application**:
   ```bash
   dotnet run --project LMS
   ```

2. **Access the web interface**: Open your browser and navigate to `https://localhost:5001`

3. **Create an account**: Use the registration page to create a new user account

4. **Explore the features**:
   - Browse available courses
   - View instructor profiles
   - Enroll in courses (as a trainee)
   - Manage courses and students (as an instructor/admin)

### Project Structure

```
LMS/
├── LMS/                    # Main web application (Presentation layer)
│   ├── Controllers/        # MVC Controllers
│   ├── Views/             # Razor views
│   ├── wwwroot/           # Static files (CSS, JS, images)
│   ├── Program.cs         # Application entry point
│   └── appsettings.json   # Configuration
│
├── Entities/              # Business entities and interfaces
│   ├── Models/            # Domain models (Course, Instructor, Trainee, etc.)
│   ├── ViewModels/        # View-specific models
│   └── IRepository/       # Repository interfaces
│
└── DataAccess/            # Data access layer
    ├── Data/              # DbContext
    ├── Migrations/        # EF Core migrations
    └── RepositoryImp/     # Repository implementations
```

### Common Operations

**Adding a new course:**
```csharp
// Navigate to /Course/Create
// Fill in the course details form
// Submit to add the course to the database
```

**Enrolling in a course:**
```csharp
// Browse courses at /Course
// Click "Enroll" on desired course
// System checks seat availability
// Enrollment is recorded in TraineeCourse table
```

## 🤝 Contributing Guidelines

We welcome contributions from the community! Here's how you can help:

### How to Contribute

1. **Fork the repository**
   ```bash
   # Click the 'Fork' button on GitHub
   ```

2. **Clone your fork**
   ```bash
   git clone https://github.com/YOUR_USERNAME/LMS.git
   cd LMS
   ```

3. **Create a feature branch**
   ```bash
   git checkout -b feature/your-feature-name
   ```

4. **Make your changes**
   - Write clean, maintainable code
   - Follow C# coding conventions
   - Add comments for complex logic
   - Update documentation if needed

5. **Test your changes**
   ```bash
   dotnet build
   dotnet run
   # Verify your changes work correctly
   ```

6. **Commit your changes**
   ```bash
   git add .
   git commit -m "Add: Brief description of your changes"
   ```

7. **Push to your fork**
   ```bash
   git push origin feature/your-feature-name
   ```

8. **Create a Pull Request**
   - Go to the original repository on GitHub
   - Click "New Pull Request"
   - Select your fork and branch
   - Provide a clear description of your changes

### Coding Standards

- Follow [C# Coding Conventions](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions)
- Use meaningful variable and method names
- Keep methods focused and concise
- Add XML documentation comments for public APIs
- Ensure your code builds without warnings

### Reporting Issues

Found a bug or have a suggestion? Please open an issue:

1. Go to the [Issues](https://github.com/Moztafaa/LMS/issues) page
2. Click "New Issue"
3. Provide a clear title and detailed description
4. Include steps to reproduce (for bugs)
5. Add relevant labels

## 📝 License

This project is licensed under the **MIT License**.

### MIT License

```
MIT License

Copyright (c) 2024 Moztafaa

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
```

See the [LICENSE](LICENSE) file for more details.

## 📧 Contact & Support

- **Author**: Moztafaa
- **Repository**: [https://github.com/Moztafaa/LMS](https://github.com/Moztafaa/LMS)
- **Issues**: [Report a bug or request a feature](https://github.com/Moztafaa/LMS/issues)

## 🙏 Acknowledgments

- Built with [ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/)
- Database powered by [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/)
- UI components from [Bootstrap](https://getbootstrap.com/)
- Authentication via [ASP.NET Core Identity](https://docs.microsoft.com/en-us/aspnet/core/security/authentication/identity)

## 📊 Project Status

This project is actively maintained and open for contributions. Feel free to star ⭐ the repository if you find it useful!

---

**Made with ❤️ by Moztafaa**
