# 🎓 Student Management System

A comprehensive web-based application designed to streamline educational institution management processes. This system provides an intuitive interface for managing student records, course enrollments, attendance tracking, grade management, and administrative tasks.

## 📋 Table of Contents

- [Features](#-features)
- [Technology Stack](#-technology-stack)
- [System Architecture](#-system-architecture)
- [Prerequisites](#-prerequisites)
- [Installation](#-installation)
- [Configuration](#-configuration)
- [Usage](#-usage)
- [API Documentation](#-api-documentation)
- [Database Schema](#-database-schema)
- [Security](#-security)
- [Deployment](#-deployment)
- [Contributing](#-contributing)
- [License](#-license)
- [Contact](#-contact)

## ✨ Features

### 👥 User Management
- **Multi-role support**: Administrator, Teacher, and Student roles
- **Secure authentication** with password hashing
- **Role-based access control** for different functionalities
- **User profile management** and customization

### 📚 Student Information Management
- Complete student record management (Add, Edit, Delete, View)
- Personal information tracking (contact details, address, etc.)
- Academic information (student ID, enrollment date, program)
- Advanced search and filtering capabilities
- Data export functionality

### 📖 Course Management
- Course catalog creation and management
- Teacher assignment to courses
- Course scheduling and timing configuration
- Capacity management and prerequisite handling
- Enrollment period management

### ✅ Attendance Tracking
- Daily attendance marking by teachers
- Comprehensive attendance reports
- Automated low attendance notifications
- Attendance percentage calculations
- Historical attendance data analysis

### 📊 Grade Management
- Grade entry for assignments, exams, and projects
- Automated GPA calculation
- Transcript generation
- Grade distribution analytics
- Performance tracking and reports

### 📈 Reporting & Analytics
- Student performance reports
- Attendance summaries
- Course enrollment statistics
- Custom report generation
- Data visualization

## 🛠️ Technology Stack

### Backend
| Technology | Version | Purpose |
|------------|---------|---------|
| **ASP.NET** | Framework 4.x / .NET Core | Core backend framework |
| **C#** | Latest | Primary programming language |
| **Entity Framework** | 6.x / Core | ORM for database operations |
| **ASP.NET MVC** | 5.x / Core | Web application framework |
| **ASP.NET Web API** | 2.x / Core | RESTful API development |
| **LINQ** | Integrated | Data querying |

### Frontend
| Technology | Purpose |
|------------|---------|
| **HTML5** | Markup language |
| **CSS3** | Styling and layout |
| **JavaScript (ES6+)** | Client-side scripting |
| **jQuery** | DOM manipulation and AJAX |
| **Bootstrap** | Responsive UI framework |

### Database
| Technology | Purpose |
|------------|---------|
| **SQL Server** | Primary RDBMS |
| **T-SQL** | Database queries and stored procedures |

### Development Tools
- Visual Studio (IDE)
- SQL Server Management Studio (SSMS)
- Git (Version control)
- NuGet (Package management)

## 🏗️ System Architecture

The application follows a **three-tier architecture**:

```
┌─────────────────────────────────────┐
│     Presentation Layer (UI)         │
│   HTML, CSS, JavaScript, Razor      │
└──────────────┬──────────────────────┘
               │
┌──────────────▼──────────────────────┐
│   Business Logic Layer (BLL)        │
│   Controllers, Services, Models     │
└──────────────┬──────────────────────┘
               │
┌──────────────▼──────────────────────┐
│   Data Access Layer (DAL)           │
│   Entity Framework, Repositories    │
└──────────────┬──────────────────────┘
               │
┌──────────────▼──────────────────────┐
│        Database (SQL Server)        │
└─────────────────────────────────────┘
```

**Design Pattern**: Model-View-Controller (MVC)
- **Models**: Data structures and business logic
- **Views**: User interface (Razor views)
- **Controllers**: Request handling and flow control

## 📦 Prerequisites

Before you begin, ensure you have the following installed:

- **Visual Studio 2019/2022** (Community, Professional, or Enterprise)
- **.NET Framework 4.7.2+** or **.NET Core 3.1+ / .NET 5+**
- **SQL Server 2016+** or **SQL Server Express**
- **SQL Server Management Studio (SSMS)** (recommended)
- **Git** for version control
- Modern web browser (Chrome, Firefox, Edge)

## 🚀 Installation

### 1. Clone the Repository

```bash
git clone https://github.com/JoeDev000/Student-Management-System.git
cd Student-Management-System
```

### 2. Open Solution in Visual Studio

```bash
# Open the solution file
start StudentsManagementSystem.sln
```

Or manually open `StudentsManagementSystem.sln` in Visual Studio.

### 3. Restore NuGet Packages

Visual Studio should automatically restore packages. If not:

```
Tools → NuGet Package Manager → Restore NuGet Packages
```

### 4. Configure Database Connection

Update the connection string in `Web.config` (or `appsettings.json` for .NET Core):

```xml
<connectionStrings>
  <add name="DefaultConnection" 
       connectionString="Server=localhost;Database=StudentManagementDB;Trusted_Connection=True;" 
       providerName="System.Data.SqlClient" />
</connectionStrings>
```

Or for .NET Core in `appsettings.json`:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=StudentManagementDB;Trusted_Connection=True;"
  }
}
```

### 5. Create Database

#### Option A: Using Entity Framework Migrations

Open **Package Manager Console** in Visual Studio:

```powershell
Update-Database
```

#### Option B: Using SQL Scripts

Execute the provided SQL scripts in SSMS:
1. Open SSMS and connect to your SQL Server
2. Run the database creation scripts from the `/Database` folder (if available)

### 6. Build the Solution

```
Build → Build Solution (Ctrl + Shift + B)
```

### 7. Run the Application

Press **F5** or click **Start** to run the application in debug mode.

The application will open in your default browser at `https://localhost:PORT`

## ⚙️ Configuration

### Default Login Credentials

After initial database setup, use these credentials:

**Administrator Account:**
```
Username: admin
Password: Admin@123
```

⚠️ **Important**: Change default passwords immediately after first login!

### Application Settings

Configure the following in `Web.config` or `appsettings.json`:

- **SMTP Settings** (for email notifications)
- **Session Timeout**
- **File Upload Limits**
- **Logging Configuration**
- **Security Settings**

## 📖 Usage

### Administrator Functions
- Manage user accounts (create, edit, delete)
- Configure system settings
- Generate comprehensive reports
- Assign roles and permissions
- Monitor system activity

### Teacher Functions
- Mark student attendance
- Enter and manage grades
- View enrolled students
- Upload course materials
- Communicate with students

### Student Functions
- View personal information
- Check grades and transcripts
- View attendance records
- Access course materials
- Enroll in courses

## 🔌 API Documentation

### Authentication Required

All API endpoints require authentication unless otherwise specified.

### Student Endpoints

| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | `/api/students` | Get all students |
| GET | `/api/students/{id}` | Get student by ID |
| POST | `/api/students` | Create new student |
| PUT | `/api/students/{id}` | Update student |
| DELETE | `/api/students/{id}` | Delete student |
| GET | `/api/students/search?q={query}` | Search students |

### Course Endpoints

| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | `/api/courses` | Get all courses |
| GET | `/api/courses/{id}` | Get course by ID |
| POST | `/api/courses` | Create new course |
| PUT | `/api/courses/{id}` | Update course |
| DELETE | `/api/courses/{id}` | Delete course |
| GET | `/api/courses/{id}/students` | Get enrolled students |

### Enrollment Endpoints

| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | `/api/enrollments` | Get all enrollments |
| POST | `/api/enrollments` | Enroll student |
| DELETE | `/api/enrollments/{id}` | Drop enrollment |
| GET | `/api/enrollments/student/{id}` | Get student enrollments |

### Attendance Endpoints

| Method | Endpoint | Description |
|--------|----------|-------------|
| POST | `/api/attendance` | Mark attendance |
| GET | `/api/attendance/student/{id}` | Get student attendance |
| GET | `/api/attendance/course/{id}` | Get course attendance |
| PUT | `/api/attendance/{id}` | Update attendance |

### Request/Response Format

All requests and responses use JSON format.

**Example Request:**
```json
POST /api/students
{
  "firstName": "John",
  "lastName": "Doe",
  "email": "john.doe@example.com",
  "phone": "123-456-7890",
  "dateOfBirth": "2000-01-01",
  "programId": 1
}
```

**Example Response:**
```json
{
  "success": true,
  "message": "Student created successfully",
  "data": {
    "studentId": 123,
    "firstName": "John",
    "lastName": "Doe",
    "email": "john.doe@example.com"
  }
}
```

## 🗄️ Database Schema

### Core Tables

#### Students
```sql
CREATE TABLE Students (
    StudentID INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    Email NVARCHAR(100) UNIQUE NOT NULL,
    Phone NVARCHAR(20),
    DateOfBirth DATE NOT NULL,
    Address NVARCHAR(200),
    EnrollmentDate DATE NOT NULL,
    ProgramID INT FOREIGN KEY REFERENCES Programs(ProgramID),
    Status NVARCHAR(20) NOT NULL,
    CreatedDate DATETIME DEFAULT GETDATE()
);
```

#### Courses
```sql
CREATE TABLE Courses (
    CourseID INT PRIMARY KEY IDENTITY(1,1),
    CourseCode NVARCHAR(20) UNIQUE NOT NULL,
    CourseName NVARCHAR(100) NOT NULL,
    Credits INT NOT NULL,
    DepartmentID INT FOREIGN KEY REFERENCES Departments(DepartmentID),
    Description NVARCHAR(500),
    MaxCapacity INT
);
```

#### Enrollments
```sql
CREATE TABLE Enrollments (
    EnrollmentID INT PRIMARY KEY IDENTITY(1,1),
    StudentID INT FOREIGN KEY REFERENCES Students(StudentID),
    CourseID INT FOREIGN KEY REFERENCES Courses(CourseID),
    Semester NVARCHAR(20) NOT NULL,
    Year INT NOT NULL,
    Grade NVARCHAR(5),
    EnrollmentDate DATE DEFAULT GETDATE(),
    Status NVARCHAR(20) NOT NULL
);
```

#### Attendance
```sql
CREATE TABLE Attendance (
    AttendanceID INT PRIMARY KEY IDENTITY(1,1),
    StudentID INT FOREIGN KEY REFERENCES Students(StudentID),
    CourseID INT FOREIGN KEY REFERENCES Courses(CourseID),
    AttendanceDate DATE NOT NULL,
    Status NVARCHAR(20) NOT NULL,
    Notes NVARCHAR(200),
    RecordedBy INT FOREIGN KEY REFERENCES Users(UserID)
);
```

### Entity Relationships

```
Students ──┬── One-to-Many ──→ Enrollments
           └── One-to-Many ──→ Attendance
           
Courses ───┬── One-to-Many ──→ Enrollments
           └── One-to-Many ──→ Attendance
           
Users ─────── One-to-One ──→ Students
```

## 🔒 Security

### Authentication
- Secure password hashing using cryptographic algorithms
- Session-based authentication
- Password reset functionality via email
- Account lockout after failed login attempts

### Authorization
- Role-based access control (RBAC)
- Controller and action-level authorization
- View-level content restriction
- Database-level row security (optional)

### Data Protection
- **SQL Injection Prevention**: Parameterized queries and ORM
- **XSS Protection**: Input encoding and validation
- **CSRF Protection**: Anti-forgery tokens on forms
- **HTTPS Enforcement**: Encrypted data transmission
- **Input Validation**: Client and server-side validation

### Best Practices
- Regular security updates and patching
- Secure configuration management
- Connection string encryption
- Audit logging for sensitive operations
- Regular security assessments

## 🚀 Deployment

### IIS Deployment

1. **Publish Application**
   ```
   Build → Publish → Select Target (Folder/IIS/Azure)
   ```

2. **Configure IIS**
   - Create new Application Pool
   - Create Website or Application
   - Point to published directory
   - Configure SSL certificate

3. **Update Configuration**
   - Set production connection strings
   - Disable debug mode
   - Enable custom error pages
   - Configure logging

### Azure Deployment

1. Create Azure App Service
2. Create Azure SQL Database
3. Configure connection strings in App Service settings
4. Deploy using Visual Studio publish profile or CI/CD
5. Configure custom domain and SSL
6. Set up monitoring and diagnostics

### Docker Deployment (Optional)

```dockerfile
# Example Dockerfile
FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["StudentManagementSystem.csproj", "./"]
RUN dotnet restore
COPY . .
RUN dotnet build -c Release -o /app/build

FROM build AS publish
RUN dotnet publish -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "StudentManagementSystem.dll"]
```

## 🤝 Contributing

Contributions are welcome! Please follow these steps:

1. **Fork the Repository**
   ```bash
   git clone https://github.com/YOUR-USERNAME/Student-Management-System.git
   ```

2. **Create a Feature Branch**
   ```bash
   git checkout -b feature/AmazingFeature
   ```

3. **Commit Your Changes**
   ```bash
   git commit -m 'Add some AmazingFeature'
   ```

4. **Push to the Branch**
   ```bash
   git push origin feature/AmazingFeature
   ```

5. **Open a Pull Request**

### Coding Standards
- Follow C# coding conventions
- Write meaningful commit messages
- Include comments for complex logic
- Write unit tests for new features
- Update documentation as needed

## 📝 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 📞 Contact

**Project Maintainer**: JoeDev000

- GitHub: [@JoeDev000](https://github.com/JoeDev000)
- Project Link: [https://github.com/JoeDev000/Student-Management-System](https://github.com/JoeDev000/Student-Management-System)
---

**⭐ If you find this project helpful, please consider giving it a star!**
