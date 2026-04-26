# MXHRM - Modern HRM Management System

![Status](https://img.shields.io/badge/status-active-brightgreen)
![Version](https://img.shields.io/badge/version-1.0.0-blue)
![License](https://img.shields.io/badge/license-MIT-green)
![.NET](https://img.shields.io/badge/.NET-10-512BD4)
![Angular](https://img.shields.io/badge/Angular-21+-DD0031)

**MXHRM** is a modern, enterprise-grade Human Resource Management system designed to streamline employee lifecycle management, payroll operations, leave management, and attendance tracking. Built with a clean architecture approach using **.NET 10** and **Angular 21+**, the system emphasizes scalability, maintainability, and cutting-edge user experience.

---

## 📋 Table of Contents

- [Project Overview](#project-overview)
- [Technology Stack](#technology-stack)
- [System Architecture](#system-architecture)
- [Project Structure](#project-structure)
- [Getting Started](#getting-started)
- [Development Roadmap](#development-roadmap)
- [API Documentation](#api-documentation)
- [Database Schema](#database-schema)
- [Testing Strategy](#testing-strategy)
- [Deployment & DevOps](#deployment--devops)
- [Contributing Guidelines](#contributing-guidelines)
- [Team & Support](#team--support)

---

## 🎯 Project Overview

### Purpose
MXHRM provides a comprehensive solution for managing:
- **Employee Management**: CRUD operations, employee records, organizational hierarchy
- **Leave Management**: Leave request handling, balance tracking, approval workflows
- **Payroll System**: Salary calculations, deductions, payslip generation
- **Attendance Tracking**: Clock-in/out, attendance reports, compliance monitoring
- **Reporting & Analytics**: Custom reports powered by Telerik Reporting

### Key Features
✅ Role-based access control (RBAC) with permission-based authorization  
✅ JWT authentication with refresh token mechanism  
✅ Real-time data updates with caching layer  
✅ RESTful API with comprehensive error handling  
✅ Responsive Angular UI with Kendo components  
✅ Fully automated CI/CD pipeline  
✅ Unit & integration testing coverage  
✅ Multi-environment deployment support  
✅ Advanced Angular signals for reactive state management  
✅ Control flow syntax support (@if, @for, @switch)  

---

## 💻 Technology Stack

### Backend (.NET 10)
| Layer | Technology | Purpose | Version |
|-------|-----------|---------|---------|
| **Framework** | ASP.NET Core 10 | Web API framework | 10.0+ |
| **Database ORM** | Entity Framework Core 10 | Data access layer | 10.0+ |
| **Database** | SQL Server | Primary data store | 2022+ |
| **Authentication** | ASP.NET Core Identity + JWT | User authentication & authorization | v10 |
| **Business Logic** | MediatR | CQRS pattern implementation | 12.x |
| **Mapping** | AutoMapper | Object-object mapping | 13.x |
| **Validation** | FluentValidation | Input validation | 11.x |
| **Caching** | Redis (StackExchange.Redis) | Distributed caching | 7.x |
| **Blob Storage** | Azure Blob Storage | File management | Latest |
| **Email Service** | SendGrid | Email notifications | v3 |
| **Reporting** | Telerik Reporting | Business intelligence reports | 2024 |
| **API Documentation** | Swagger/OpenAPI 3.1 | Interactive API docs | 3.1 |

**Key .NET 10 Features Utilized:**
- ✨ Improved performance & throughput
- 📊 Enhanced diagnostics & observability
- 🔐 Modern security features
- 🚀 Native AOT compilation ready
- 🎯 Source generators improvements
- 🧵 Enhanced async/await patterns

### Frontend (Angular 21+)
| Technology | Purpose | Version |
|-----------|---------|---------|
| **Framework** | Angular 21+ (Standalone Components) | Modern SPA framework | 21.0+ |
| **UI Components** | Kendo UI for Angular | Enterprise-grade UI controls | 16.x+ |
| **Forms** | Reactive Forms & Control Flow | Complex form management | v21 |
| **State Management** | Angular Signals + NgRx (Optional) | Reactive state management | Signals API |
| **HTTP Client** | HttpClient + Interceptors | API communication | v21 |
| **Testing** | Jest + @testing-library/angular | Unit & component testing | Latest |
| **E2E Testing** | Playwright | End-to-end testing | 1.40+ |
| **Styling** | Bootstrap 5 + Tailwind CSS | CSS frameworks | Latest |
| **Client Generation** | NSwag | TypeScript model auto-generation | Latest |
| **Rendering** | Server-Side Rendering (SSR) Ready | Performance optimization | Experimental |

**Key Angular 21+ Features Utilized:**
- 🎯 Control flow syntax (@if, @for, @switch, @defer)
- 📡 Angular Signals for fine-grained reactivity
- ⚡ Faster change detection with OnPush strategies
- 🔄 Deferred loading (@defer) for performance
- 🎨 Material 3 design system ready
- 🌐 Enhanced template type-checking

### DevOps & Infrastructure
| Tool | Purpose | Version |
|------|---------|---------|
| **CI/CD** | Azure DevOps YAML Pipelines | Automated build & deployment | Latest |
| **Containerization** | Docker | Application containerization | 24.x+ |
| **Orchestration** | Azure App Service / Kubernetes | Cloud deployment platform | - |
| **IaC** | Azure Resource Manager / Bicep | Infrastructure as code | Latest |
| **Monitoring** | Application Insights | APM & diagnostics | Latest |
| **Version Control** | Git (GitHub/Azure Repos) | Source code management | - |
| **Package Manager** | NuGet / npm | Dependency management | Latest |

### Testing Frameworks
| Framework | Layer | Purpose | Version |
|-----------|-------|---------|---------|
| **xUnit** | Backend | Unit testing framework | 2.7+ |
| **Moq** | Backend | Mocking library | 4.20+ |
| **FluentAssertions** | Backend | Assertion fluency | 6.12+ |
| **TestContainers** | Backend | Containerized integration tests | 3.6+ |
| **Jest** | Frontend | JavaScript testing framework | 29.x+ |
| **@testing-library** | Frontend | Component testing utilities | 14.x+ |
| **Playwright** | Frontend | E2E testing | 1.40+ |

---

## 🏗️ System Architecture

### Clean Architecture (4-Layer)

```
┌─────────────────────────────────────────────────────────┐
│      Presentation Layer (API)                           │
│  Controllers, Middleware, Filters, Endpoints            │
└────────────────┬────────────────────────────────────────┘
                 │ Depends on
┌────────────────▼────────────────────────────────────────┐
│     Application Layer                                   │
│  CQRS, DTOs, Validators, Mappers, MediatR Behaviors    │
└────────────────┬────────────────────────────────────────┘
                 │ Depends on
┌────────────────▼────────────────────────────────────────┐
│      Domain Layer                                       │
│  Entities, Value Objects, Aggregates, Domain Events    │
└────────────────┬────────────────────────────────────────┘
                 │ Depends on
┌────────────────▼────────────────────────────────────────┐
│   Infrastructure Layer                                  │
│ EF Core, Repositories, Services, External Integrations │
└─────────────────────────────────────────────────────────┘
```

### CQRS Pattern with MediatR
- **Commands**: State-changing operations (Create, Update, Delete)
- **Queries**: Read operations (Get, Search, List)
- **Handlers**: Business logic execution with validation pipeline
- **Behaviors**: Cross-cutting concerns (validation, logging, timing)

### Authentication & Authorization Flow
```
┌──────────┐     ┌──────────┐     ┌──────────────┐     ┌──────────┐
│ Client   │────▶│ Login    │────▶│ JWT Token    │────▶│ API      │
│ (Angular)│     │ Endpoint │     │ + Refresh    │     │ Requests │
└──────────┘     └──────────┘     └──────────────┘     └──────────┘
                                            │
                                            ▼
                                   ┌──────────────────┐
                                   │ localStorage/    │
                                   │ sessionStorage   │
                                   └──────────────────┘
```

### Caching Strategy
```
Request → API Controller → Redis Cache Check
                           ├─ Hit: Return from cache
                           └─ Miss: Query database → Store in cache
```

---

## 📁 Project Structure

### Backend Structure (.NET 10)
```
HRM-System/
├── src/
│   ├── HRM.Api/                          # REST API Layer
│   │   ├── Controllers/v1/               # API endpoints (RESTful)
│   │   ├── Middleware/                   # Custom middleware (exception, logging)
│   │   ├── Filters/                      # Action filters (validation, auth)
│   │   ├── Mappers/                      # Response mappers
│   │   ├── Extensions/                   # DI setup, service extensions
│   │   ├── Program.cs                    # Application entry point (top-level statements)
│   │   ├── appsettings.json              # Configuration
│   │   └── appsettings.Development.json  # Dev environment config
│   │
│   ├── HRM.Application/                  # Business Logic Layer (CQRS)
│   │   ├── Common/
│   │   │   ├── Interfaces/               # IRepository, IUnitOfWork, IService
│   │   │   ├── Mappings/                 # AutoMapper profiles
│   │   │   ├── Behaviours/               # MediatR pipeline behaviors
│   │   │   └── Exceptions/               # Custom exceptions
│   │   ├── Employees/
│   │   │   ├── Commands/                 # CreateEmployeeCommand, UpdateEmployeeCommand
│   │   │   ├── Queries/                  # GetEmployeeListQuery, GetEmployeeByIdQuery
│   │   │   ├── Handlers/                 # Command/Query handlers
│   │   │   ├── DTOs/                     # EmployeeReadDto, EmployeeWriteDto
│   │   │   └── Validators/               # FluentValidation rules
│   │   ├── Leave/                        # Leave management module
│   │   │   └── Commands/ Queries/ Handlers/ DTOs/ Validators/
│   │   ├── Payroll/                      # Payroll calculation module
│   │   │   └── Commands/ Queries/ Handlers/ DTOs/
│   │   ├── Attendance/                   # Attendance tracking module
│   │   │   └── Commands/ Queries/ Handlers/ DTOs/
│   │   └── DependencyInjection.cs        # Application layer service registration
│   │
│   ├── HRM.Domain/                       # Core Domain Layer
│   │   ├── Entities/                     # Aggregate roots (Employee, Department, etc.)
│   │   ├── ValueObjects/                 # EmployeeCode, Money, DateRange, Address
│   │   ├── Enums/                        # EmployeeStatus, LeaveType, Gender
│   │   ├── Events/                       # Domain events (EmployeeCreated, etc.)
│   │   ├── Interfaces/                   # Repository contracts, Domain service interfaces
│   │   └── Exceptions/                   # Domain-specific exceptions
│   │
│   └── HRM.Infrastructure/               # Data & External Services
│       ├── Persistence/
│       │   ├── HrmDbContext.cs           # EF Core DbContext
│       │   ├── Configurations/           # IEntityTypeConfiguration per entity
│       │   ├── Repositories/             # Generic & specific repository implementations
│       │   ├── Migrations/               # EF Code First migrations
│       │   └── UnitOfWork.cs             # Unit of work pattern implementation
│       ├── Identity/
│       │   ├── ApplicationUser.cs        # Custom ASP.NET Identity user
│       │   ├── ApplicationRole.cs        # Custom roles
│       │   └── PermissionService.cs      # Permission evaluation service
│       ├── Caching/
│       │   ├── RedisCacheService.cs      # Redis cache wrapper
│       │   └── CacheKeys.cs              # Cache key constants
│       ├── Storage/
│       │   └── BlobStorageService.cs     # Azure Blob Storage integration
│       ├── Notifications/
│       │   ├── EmailService.cs           # SendGrid email integration
│       │   └── SmsService.cs             # (Optional) SMS service
│       ├── Reports/
│       │   ├── TelerikReportService.cs   # Telerik reporting service
│       │   └── ReportDefinitions/        # .trdp report definition files
│       └── DependencyInjection.cs        # Infrastructure layer service registration
│
├── tests/
│   └── HRM.Tests/
│       ├── Unit/
│       │   ├── Application/
│       │   │   └── Employees/            # CreateEmployeeCommandHandlerTests, etc.
│       │   ├── Domain/                   # EmployeeTests, LeaveRequestTests
│       │   └── Common/                   # TestBase, Utilities
│       ├── Integration/
│       │   ├── Api/                      # EmployeeApiTests, LeaveApiTests
│       │   ├── Persistence/              # EmployeeRepositoryTests
│       │   ├── IntegrationTestBase.cs    # Base class with TestContainers
│       │   └── CustomWebApplicationFactory.cs # WebApplicationFactory
│       ├── Fixtures/
│       │   ├── EmployeeFaker.cs          # Bogus data factory
│       │   └── LeaveFaker.cs
│       └── GlobalUsings.cs               # Global using statements
│
├── HRM.sln                               # Visual Studio solution
├── Directory.Build.props                 # Shared NuGet versions & settings
└── .editorconfig                         # Code style rules
```

### Frontend Structure (Angular 21+)
```
hrm-angular/
├── src/
│   ├── app/
│   │   ├── core/                         # Singleton services & utilities
│   │   │   ├── auth/
│   │   │   │   ├── auth.service.ts       # JWT token management, login/logout
│   │   │   │   ├── auth.guard.ts         # Route guard for authentication
│   │   │   │   ├── auth.interceptor.ts   # Add JWT to requests
│   │   │   │   └── role.guard.ts         # Role-based route guard
│   │   │   ├── http/
│   │   │   │   ├── api.service.ts        # Base HTTP service
│   │   │   │   └── http.interceptor.ts   # Error handling interceptor
│   │   │   ├── layout/
│   │   │   │   ├── app-shell.component.ts # Main shell component
│   │   │   │   ├── navbar.component.ts
│   │   │   │   └── sidebar.component.ts
│   │   │   └── interceptors/
│   │   │       ├── jwt.interceptor.ts
│   │   │       ├── error.interceptor.ts
│   │   │       └── loading.interceptor.ts
│   │   │
│   │   ├── shared/                       # Reusable, feature-agnostic
│   │   │   ├── components/
│   │   │   │   ├── kendo-grid/           # Kendo Grid wrapper
│   │   │   │   ├── kendo-form/           # Kendo Form wrapper
│   │   │   │   ├── pagination/           # Pagination component
│   │   │   │   └── data-table/           # Generic data table
│   │   │   ├── pipes/
│   │   │   │   ├── date-th.pipe.ts       # Thai date format pipe
│   │   │   │   ├── currency-th.pipe.ts   # Thai currency format pipe
│   │   │   │   └── safe-html.pipe.ts     # Safe HTML rendering
│   │   │   ├── directives/
│   │   │   │   ├── click-outside.directive.ts
│   │   │   │   └── highlight.directive.ts
│   │   │   └── models/
│   │   │       └── Generated from NSwag  # Auto-generated DTOs from backend
│   │   │
│   │   ├── features/                     # Feature modules (lazy-loaded)
│   │   │   ├── employee/
│   │   │   │   ├── employee-list/        # Kendo Grid with search/filter
│   │   │   │   ├── employee-form/        # Reactive form for CRUD
│   │   │   │   ├── employee-detail/      # Detail view
│   │   │   │   ├── employee.service.ts   # HTTP service for employee API
│   │   │   │   └── employee.routes.ts    # Feature routing
│   │   │   ├── leave/
│   │   │   │   ├── leave-request-list/
│   │   │   │   ├── leave-request-form/
│   │   │   │   ├── leave-approval/
│   │   │   │   ├── leave.service.ts
│   │   │   │   └── leave.routes.ts
│   │   │   ├── payroll/
│   │   │   │   ├── salary-info/
│   │   │   │   ├── payroll-process/
│   │   │   │   ├── payslip-viewer/
│   │   │   │   ├── payroll.service.ts
│   │   │   │   └── payroll.routes.ts
│   │   │   ├── attendance/
│   │   │   │   ├── attendance-dashboard/
│   │   │   │   ├── clock-in-out/
│   │   │   │   ├── attendance.service.ts
│   │   │   │   └── attendance.routes.ts
│   │   │   ├── report/
│   │   │   │   ├── report-viewer/        # Telerik report viewer
│   │   │   │   ├── report-generator/
│   │   │   │   ├── report.service.ts
│   │   │   │   └── report.routes.ts
│   │   │   └── dashboard/
│   │   │       ├── dashboard.component.ts
│   │   │       └── dashboard.routes.ts
│   │   │
│   │   ├── store/                        # NgRx state management (optional)
│   │   │   ├── employee/
│   │   │   │   ├── employee.actions.ts
│   │   │   │   ├── employee.reducer.ts
│   │   │   │   ├── employee.selectors.ts
│   │   │   │   └── employee.effects.ts
│   │   │   ├── leave/
│   │   │   │   └── (similar structure)
│   │   │   └── payroll/
│   │   │       └── (similar structure)
│   │   │
│   │   ├── app.component.ts              # Root component
│   │   ├── app.routes.ts                 # Main routing configuration
│   │   └── app.config.ts                 # App configuration (standalone)
│   │
│   ├── assets/                           # Static assets (images, icons)
│   ├── environments/
│   │   ├── environment.ts                # Development environment config
│   │   ├── environment.prod.ts           # Production environment config
│   │   └── environment.staging.ts        # Staging environment config
│   ├── index.html                        # HTML entry point
│   ├── main.ts                           # Bootstrap entry point
│   └── styles.scss                       # Global styles
│
├── angular.json                          # Angular CLI configuration
├── jest.config.ts                        # Jest testing configuration
├── jest.preset.js                        # Jest preset
├── playwright.config.ts                  # Playwright E2E configuration
├── tsconfig.json                         # TypeScript configuration
├── tsconfig.app.json                     # App TypeScript config
├── tsconfig.spec.json                    # Test TypeScript config
├── package.json                          # NPM dependencies
├── package-lock.json                     # Locked dependency versions
└── nswag.json                            # NSwag code generation config
```

### DevOps Structure
```
HRM-System/
├── .azure/                               # Azure DevOps pipelines
│   ├── pipeline-build.yml                # Build: dotnet build, ng build
│   ├── pipeline-test.yml                 # Test: xUnit, Jest with coverage gates
│   ├── pipeline-deploy-staging.yml       # Deploy to staging environment
│   └── pipeline-deploy-prod.yml          # Deploy to production
│
├── docker/                               # Docker configurations
│   ├── docker-compose.yml                # Local dev environment (SQL, Redis, API, Angular)
│   ├── docker-compose.prod.yml           # Production compose
│   ├── Dockerfile.api                    # Multi-stage build for .NET API
│   ├── Dockerfile.angular                # Multi-stage build for Angular SPA
│   └── .dockerignore
│
├── docs/                                 # Documentation
│   ├── architecture.md                   # System architecture details
│   ├── api-conventions.md                # API design conventions & standards
│   ├── database-migrations.md            # Database migration strategy
│   ├── setup-guide.md                    # Detailed setup instructions
│   ├── deployment-guide.md               # Deployment procedures
│   └── troubleshooting.md                # Common issues & solutions
│
└── .github/                              # GitHub Actions (optional alternative to Azure DevOps)
    └── workflows/
        ├── build.yml
        ├── test.yml
        └── deploy.yml
```

---

## 🚀 Getting Started

### Prerequisites
- **.NET 10 SDK** (10.0 or later) - [Download](https://dotnet.microsoft.com/download)
- **Node.js 20+** & **npm 10+** - [Download](https://nodejs.org/)
- **SQL Server 2022+** (local or Azure) - [Download](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- **Redis 7+** (optional for caching) - [Download](https://redis.io/download)
- **Docker & Docker Compose** (for containerized development)
- **Visual Studio 2024** or **VS Code** with C# extension
- **Git** for version control

### Backend Setup (.NET 10)

#### 1. Clone & Navigate
```bash
git clone https://github.com/your-org/MXHRM.git
cd HRM-System
```

#### 2. Verify .NET Installation
```bash
dotnet --version
# Should output 10.0 or higher
```

#### 3. Restore NuGet Packages
```bash
dotnet restore
```

#### 4. Configure Database Connection
Edit `src/HRM.Api/appsettings.Development.json`:
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=HrmDb;Trusted_Connection=true;Encrypt=false;"
  },
  "RedisSettings": {
    "ConnectionString": "localhost:6379"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning"
    }
  }
}
```

#### 5. Apply Database Migrations
```bash
cd src/HRM.Api
dotnet ef database update --project ../HRM.Infrastructure
# Or for fresh database:
dotnet ef database drop
dotnet ef database update
```

#### 6. Seed Initial Data (Optional)
```bash
# Data is automatically seeded via migrations
# Additional data can be added via seed script
dotnet run --project src/HRM.Api -- --seed-data
```

#### 7. Run the API Server
```bash
dotnet run --project src/HRM.Api
# API available at: https://localhost:5001
# Swagger UI available at: https://localhost:5001/swagger
```

### Frontend Setup (Angular 21+)

#### 1. Navigate to Angular Project
```bash
cd src/hrm-angular
```

#### 2. Verify Node.js & npm
```bash
node --version
# Should output v20 or higher
npm --version
# Should output 10 or higher
```

#### 3. Install Dependencies
```bash
npm install
# or use npm ci for exact versions
npm ci
```

#### 4. Configure API Endpoint
Edit `src/environments/environment.ts`:
```typescript
export const environment = {
  production: false,
  apiUrl: 'https://localhost:5001/api/v1',
  tokenKey: 'access_token',
  refreshTokenKey: 'refresh_token'
};
```

#### 5. Generate TypeScript Models from OpenAPI (Optional)
```bash
# Install NSwag CLI (one-time)
npm install -g nswag

# Generate models from backend OpenAPI spec
nswag run nswag.json
# Generated models will be in src/app/shared/models/
```

#### 6. Run Angular Development Server
```bash
ng serve
# or
npm start
# Navigate to http://localhost:4200
# Changes automatically reload in browser
```

### Full Stack with Docker Compose

#### 1. Ensure Docker is Running
```bash
docker --version
docker-compose --version
```

#### 2. Start All Services
```bash
cd docker
docker-compose up -d

# Services will be available at:
# API: http://localhost:5001
# Angular: http://localhost:4200
# SQL Server: localhost,1433 (user: sa, password: Password123!)
# Redis: localhost:6379
```

#### 3. View Logs
```bash
docker-compose logs -f
# or specific service:
docker-compose logs -f api
```

#### 4. Stop Services
```bash
docker-compose down
# or with data cleanup:
docker-compose down -v
```

---

## 📅 Development Roadmap

### Phase 1️⃣: Foundation & Database (Week 1)
**Objectives**: Establish clean architecture & database layer
- ✅ Create .NET 10 Solution with Clean Architecture (4-layer)
- ✅ Setup Entity Framework Core 10 + SQL Server 2022
- ✅ Design & implement database schema (Employee, Department, Position, Role, Permission)
- ✅ Create EF Core migrations
- ✅ Seed base data (departments, positions, roles)
- ⏱️ **Duration**: 1 week
- 📊 **Deliverables**: Solution structure, database schema, migrations

### Phase 2️⃣: ASP.NET Core Identity & Authentication (Week 1)
**Objectives**: Implement secure authentication mechanism
- ✅ Install & configure ASP.NET Core Identity
- ✅ Setup JWT (JSON Web Tokens) authentication middleware
- ✅ Create AuthController with Login, Refresh Token endpoints
- ✅ Implement Role-based & Permission-based Authorization policies
- ✅ Configure CORS for frontend communication
- ⏱️ **Duration**: 1 week
- 📊 **Deliverables**: Auth endpoints, JWT token generation, authorization policies

### Phase 3️⃣: Domain & Application Layer (Week 1.5)
**Objectives**: Build business logic layer with CQRS pattern
- ✅ Create Core Domain Entities (Employee, Leave, Payroll, Attendance, Department)
- ✅ Define Value Objects (EmployeeCode, Money, DateRange, Address)
- ✅ Create DTOs (ReadDto, WriteDto, UpdateDto) with validation
- ✅ Setup AutoMapper profiles for entity-to-DTO mapping
- ✅ Configure MediatR for CQRS pattern (Commands, Queries, Handlers)
- ✅ Implement validation behaviors in MediatR pipeline
- ⏱️ **Duration**: 1.5 weeks
- 📊 **Deliverables**: Domain entities, DTOs, MediatR handlers, validation rules

### Phase 4️⃣: Repository & Infrastructure Layer (Week 1.5)
**Objectives**: Setup data access & external service integrations
- ✅ Implement Generic Repository<T> + Unit of Work pattern
- ✅ Setup Redis caching layer with cache key strategy
- ✅ Configure Azure Blob Storage for file uploads
- ✅ Integrate SendGrid for email notifications
- ✅ Setup application logging & diagnostics
- ⏱️ **Duration**: 1.5 weeks
- 📊 **Deliverables**: Repository pattern, caching, external service integrations

### Phase 5️⃣: Core API Endpoints (Week 2)
**Objectives**: Expose REST API endpoints for business operations
- ✅ Implement Employee CRUD endpoints (/api/v1/employees)
- ✅ Implement Leave Management endpoints
- ✅ Implement Payroll endpoints
- ✅ Implement Attendance endpoints
- ✅ Add pagination, filtering, sorting support
- ✅ Configure Swagger/OpenAPI documentation
- ⏱️ **Duration**: 2 weeks
- 📊 **Deliverables**: Complete REST API with documentation

### Phase 6️⃣: Angular 21+ Project Setup (Week 1)
**Objectives**: Bootstrap modern Angular application
- ✅ Create Angular 21+ project with standalone components
- ✅ Integrate Kendo UI for Angular
- ✅ Setup routing with feature modules (lazy loading)
- ✅ Configure HTTP interceptors (JWT, error handling, loading states)
- ✅ Setup environment configurations (dev, staging, prod)
- ⏱️ **Duration**: 1 week
- 📊 **Deliverables**: Angular project structure, routing, interceptors

### Phase 7️⃣: Authentication UI (Week 1)
**Objectives**: Implement login/logout functionality
- ✅ Create AuthService for JWT token management
- ✅ Build Login component with reactive forms validation
- ✅ Implement AuthGuard for route protection
- ✅ Create RoleGuard for role-based access
- ✅ Add logout functionality with token cleanup
- ✅ Test end-to-end login flow
- ⏱️ **Duration**: 1 week
- 📊 **Deliverables**: Authentication UI, guards, service

### Phase 8️⃣: Employee Module (Week 1.5)
**Objectives**: Build employee management interface
- ✅ Create EmployeeService with CRUD methods + search/filter
- ✅ Generate TypeScript models from OpenAPI (NSwag)
- ✅ Build Employee List component with Kendo Grid (sort, paginate, filter)
- ✅ Build Employee Form component (Create/Edit) with reactive forms
- ✅ Implement delete confirmation dialog
- ✅ Add form validation & error handling
- ⏱️ **Duration**: 1.5 weeks
- 📊 **Deliverables**: Employee module with CRUD UI

### Phase 9️⃣: Unit & Integration Testing (Week 1.5)
**Objectives**: Establish comprehensive test coverage
- ✅ Setup xUnit + Moq + FluentAssertions for backend
- ✅ Write unit tests for domain entities & application handlers
- ✅ Setup Jest + Testing Library for Angular components
- ✅ Setup WebApplicationFactory for API integration tests
- ✅ Configure TestContainers for database testing
- ✅ Create CI/CD test gates (>80% coverage requirement)
- ⏱️ **Duration**: 1.5 weeks
- 📊 **Deliverables**: Test projects, test suites, coverage reports

### Phase 🔟: CI/CD Pipeline & Deployment (Week 1.5)
**Objectives**: Automate build, test, and deployment
- ✅ Create Azure DevOps YAML pipelines (build, test, deploy)
- ✅ Configure multi-stage deployments (staging → production)
- ✅ Setup code coverage gates (fail if <80%)
- ✅ Configure environment-specific secrets & configurations
- ✅ Deploy to Azure App Service (API & Angular SPA separately)
- ✅ Setup monitoring & alerting (Application Insights)
- ⏱️ **Duration**: 1.5 weeks
- 📊 **Deliverables**: CI/CD pipelines, automated deployments

**Total Timeline**: ~14-15 weeks for MVP 1.0 release

---

## 🔌 API Documentation

### Base URL
```
https://api.yourdomain.com/api/v1
```

### Authentication
All endpoints (except `/auth/login`) require JWT bearer token in Authorization header:
```http
Authorization: Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9...
```

### Standard Response Format
```json
{
  "success": true,
  "message": "Operation completed successfully",
  "data": {
    // Response data object
  },
  "errors": null,
  "statusCode": 200,
  "timestamp": "2024-01-15T10:30:00Z"
}
```

### Error Response Format
```json
{
  "success": false,
  "message": "Validation failed",
  "data": null,
  "errors": [
    {
      "field": "email",
      "message": "Email is required"
    }
  ],
  "statusCode": 400,
  "timestamp": "2024-01-15T10:30:00Z"
}
```

### Core Endpoints

#### Authentication
| Method | Endpoint | Description |
|--------|----------|-------------|
| POST | `/auth/login` | User login, returns JWT + refresh token |
| POST | `/auth/refresh-token` | Refresh expired JWT token |
| POST | `/auth/logout` | Logout user, invalidate refresh token |
| POST | `/auth/change-password` | Change user password |

#### Employees (CRUD)
| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | `/employees` | List all employees (paginated: ?page=1&pageSize=10) |
| GET | `/employees?search=John` | Search employees by name/email |
| GET | `/employees?departmentId=1` | Filter by department |
| GET | `/employees/{id}` | Get employee details by ID |
| POST | `/employees` | Create new employee |
| PUT | `/employees/{id}` | Update employee information |
| DELETE | `/employees/{id}` | Delete employee |

#### Leave Management
| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | `/leave-requests` | List leave requests |
| GET | `/leave-requests/balance/{employeeId}` | Get remaining leave balance |
| POST | `/leave-requests` | Submit new leave request |
| PUT | `/leave-requests/{id}/approve` | Approve leave request |
| PUT | `/leave-requests/{id}/reject` | Reject leave request |

#### Payroll
| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | `/payroll/employees/{id}/salary` | Get employee salary information |
| POST | `/payroll/process-monthly` | Process monthly payroll |
| GET | `/payroll/payslips/{id}` | Generate/retrieve payslip |

#### Reports
| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | `/reports` | List available reports |
| GET | `/reports/{reportName}` | Generate custom report |
| GET | `/reports/{reportName}/export?format=pdf` | Export report as PDF |

### Example API Calls

**Login Example**
```bash
curl -X POST https://localhost:5001/api/v1/auth/login \
  -H "Content-Type: application/json" \
  -d '{
    "email": "user@example.com",
    "password": "SecurePassword123!"
  }'

# Response:
# {
#   "success": true,
#   "data": {
#     "accessToken": "eyJhbGciOiJIUzI1NiIs...",
#     "refreshToken": "RefreshToken123...",
#     "expiresIn": 3600
#   }
# }
```

**Get Employee List**
```bash
curl -X GET 'https://localhost:5001/api/v1/employees?page=1&pageSize=10' \
  -H "Authorization: Bearer eyJhbGciOiJIUzI1NiIs..."

# Response:
# {
#   "success": true,
#   "data": {
#     "items": [
#       {
#         "id": 1,
#         "employeeCode": "EMP001",
#         "firstName": "John",
#         "lastName": "Doe",
#         "email": "john@example.com",
#         "departmentId": 1,
#         "department": "Engineering"
#       }
#     ],
#     "totalCount": 50,
#     "page": 1,
#     "pageSize": 10
#   }
# }
```

**Create Employee**
```bash
curl -X POST https://localhost:5001/api/v1/employees \
  -H "Content-Type: application/json" \
  -H "Authorization: Bearer {token}" \
  -d '{
    "firstName": "Jane",
    "lastName": "Smith",
    "email": "jane.smith@example.com",
    "departmentId": 1,
    "positionId": 2,
    "dateOfBirth": "1990-05-15",
    "joinDate": "2024-01-01"
  }'
```

---

## 🗄️ Database Schema

### Entity-Relationship Diagram
```
┌──────────────┐
│ Employee     │ (PK: Id)
├──────────────┤
│ EmployeeCode │◄──┐
│ FirstName    │   │
│ LastName     │   │ N:1
│ Email        │   │ (FK)
│ PhoneNumber  │   │
│ DateOfBirth  │   │
│ Gender       │   │ N:1
│ Address      │   │ (FK)
│ DepartmentId ├──►│
│ PositionId   ├──►│
│ EmploymentStatus│
│ JoinDate     │   │
│ SalaryAmount │   │
└──────────────┘   │
       │ 1:N       │
       │           │
       ├─────────►│ Department
       │          │ Position
       │          │ Role
       │          │
       ├─────────► LeaveRequest
       │
       ├─────────► Attendance
       │
       └─────────► PayrollRecord
```

### Core Tables

#### Employees
```sql
CREATE TABLE Employees (
  Id INT PRIMARY KEY IDENTITY(1,1),
  EmployeeCode NVARCHAR(20) UNIQUE NOT NULL,
  FirstName NVARCHAR(100) NOT NULL,
  LastName NVARCHAR(100) NOT NULL,
  Email NVARCHAR(255) UNIQUE NOT NULL,
  PhoneNumber NVARCHAR(20),
  DateOfBirth DATE,
  Gender INT,
  Address NVARCHAR(500),
  DepartmentId INT FOREIGN KEY REFERENCES Departments(Id),
  PositionId INT FOREIGN KEY REFERENCES Positions(Id),
  EmploymentStatus INT DEFAULT 1, -- 1=Active, 2=Inactive, 3=OnLeave
  JoinDate DATE NOT NULL,
  SalaryAmount DECIMAL(12,2),
  CreatedAt DATETIME2 DEFAULT GETUTCDATE(),
  UpdatedAt DATETIME2,
  CreatedBy NVARCHAR(100),
  UpdatedBy NVARCHAR(100)
);

CREATE INDEX idx_employee_email ON Employees(Email);
CREATE INDEX idx_employee_department ON Employees(DepartmentId);
```

#### LeaveRequests
```sql
CREATE TABLE LeaveRequests (
  Id INT PRIMARY KEY IDENTITY(1,1),
  EmployeeId INT FOREIGN KEY REFERENCES Employees(Id) ON DELETE CASCADE,
  LeaveType INT NOT NULL, -- 1=Annual, 2=Sick, 3=Unpaid, etc.
  StartDate DATE NOT NULL,
  EndDate DATE NOT NULL,
  NumberOfDays INT,
  Reason NVARCHAR(1000),
  Status INT DEFAULT 0, -- 0=Pending, 1=Approved, 2=Rejected, 3=Cancelled
  ApprovedBy INT FOREIGN KEY REFERENCES Employees(Id),
  ApprovedDate DATETIME2,
  RejectionReason NVARCHAR(500),
  CreatedAt DATETIME2 DEFAULT GETUTCDATE(),
  UpdatedAt DATETIME2
);

CREATE INDEX idx_leave_employee ON LeaveRequests(EmployeeId);
CREATE INDEX idx_leave_status ON LeaveRequests(Status);
```

#### Attendance
```sql
CREATE TABLE Attendance (
  Id INT PRIMARY KEY IDENTITY(1,1),
  EmployeeId INT FOREIGN KEY REFERENCES Employees(Id) ON DELETE CASCADE,
  ClockInTime DATETIME2,
  ClockOutTime DATETIME2,
  AttendanceDate DATE NOT NULL,
  Status INT DEFAULT 0, -- 0=Present, 1=Absent, 2=Late, 3=LeftEarly
  WorkHours DECIMAL(5,2),
  OvertimeHours DECIMAL(5,2),
  Notes NVARCHAR(500),
  CreatedAt DATETIME2 DEFAULT GETUTCDATE()
);

CREATE INDEX idx_attendance_employee ON Attendance(EmployeeId);
CREATE INDEX idx_attendance_date ON Attendance(AttendanceDate);
```

---

## 🧪 Testing Strategy

### Unit Testing (.NET Backend with xUnit)

```csharp
public class CreateEmployeeCommandHandlerTests
{
    private readonly Mock<IRepository<Employee>> _mockEmployeeRepo;
    private readonly Mock<IMapper> _mockMapper;
    private readonly CreateEmployeeCommandHandler _handler;

    public CreateEmployeeCommandHandlerTests()
    {
        _mockEmployeeRepo = new Mock<IRepository<Employee>>();
        _mockMapper = new Mock<IMapper>();
        _handler = new CreateEmployeeCommandHandler(_mockEmployeeRepo.Object, _mockMapper.Object);
    }

    [Fact]
    [Trait("Category", "Unit")]
    public async Task Handle_WithValidRequest_ReturnsEmployeeId()
    {
        // Arrange
        var command = new CreateEmployeeCommand 
        { 
            FirstName = "John",
            LastName = "Doe",
            Email = "john@example.com"
        };
        var employee = new Employee("EMP001", "John", "Doe", "john@example.com");
        
        _mockMapper.Setup(m => m.Map<Employee>(command)).Returns(employee);
        _mockEmployeeRepo.Setup(r => r.Add(It.IsAny<Employee>())).Returns(employee);

        // Act
        var result = await _handler.Handle(command, CancellationToken.None);

        // Assert
        Assert.NotNull(result);
        Assert.True(result > 0);
        _mockEmployeeRepo.Verify(r => r.SaveChangesAsync(It.IsAny<CancellationToken>()), Times.Once);
    }

    [Fact]
    [Trait("Category", "Unit")]
    public async Task Handle_WithInvalidEmail_ThrowsValidationException()
    {
        // Arrange
        var command = new CreateEmployeeCommand 
        { 
            FirstName = "John",
            Email = "invalid-email" // Invalid
        };

        // Act & Assert
        await Assert.ThrowsAsync<ValidationException>(
            () => _handler.Handle(command, CancellationToken.None)
        );
    }
}
```

### Angular Component Testing (Jest + Testing Library)

```typescript
describe('LoginComponent', () => {
  let component: LoginComponent;
  let fixture: ComponentFixture<LoginComponent>;
  let authService: jasmine.SpyObj<AuthService>;

  beforeEach(async () => {
    const spy = jasmine.createSpyObj('AuthService', ['login']);

    await TestBed.configureTestingModule({
      imports: [LoginComponent],
      providers: [{ provide: AuthService, useValue: spy }]
    }).compileComponents();

    authService = TestBed.inject(AuthService) as jasmine.SpyObj<AuthService>;
    fixture = TestBed.createComponent(LoginComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  it('should display error when form is invalid', () => {
    // Arrange
    const emailInput = fixture.debugElement.query(By.css('input[name="email"]'));
    const submitBtn = fixture.debugElement.query(By.css('button[type="submit"]'));

    // Act
    emailInput.nativeElement.value = 'invalid-email';
    submitBtn.nativeElement.click();

    // Assert
    expect(component.form.invalid).toBeTruthy();
  });

  it('should call authService.login when form is submitted', fakeAsync(() => {
    // Arrange
    authService.login.and.returnValue(of({ accessToken: 'token123' }));
    component.form.patchValue({
      email: 'user@test.com',
      password: 'password123'
    });

    // Act
    component.onSubmit();
    tick();

    // Assert
    expect(authService.login).toHaveBeenCalledWith({
      email: 'user@test.com',
      password: 'password123'
    });
  }));
});
```

### Integration Testing (TestContainers + WebApplicationFactory)

```csharp
public class EmployeeApiIntegrationTests : IAsyncLifetime
{
    private readonly MsSqlContainer _dbContainer;
    private readonly CustomWebApplicationFactory _factory;
    private HttpClient _client;

    public EmployeeApiIntegrationTests()
    {
        _dbContainer = new MsSqlBuilder()
            .WithPassword("Password@123!")
            .Build();
            
        _factory = new CustomWebApplicationFactory(_dbContainer.GetConnectionString());
    }

    public async Task InitializeAsync()
    {
        await _dbContainer.StartAsync();
        _client = _factory.CreateClient();
    }

    public async Task DisposeAsync()
    {
        await _dbContainer.StopAsync();
        _factory.Dispose();
    }

    [Fact]
    [Trait("Category", "Integration")]
    public async Task GetEmployees_ReturnsOkWithPaginatedList()
    {
        // Act
        var response = await _client.GetAsync("/api/v1/employees?page=1&pageSize=10");

        // Assert
        response.StatusCode.Should().Be(HttpStatusCode.OK);
        var content = await response.Content.ReadAsStringAsync();
        var result = JsonConvert.DeserializeObject<ApiResponse<PaginatedResponse<EmployeeReadDto>>>(content);
        result.Success.Should().BeTrue();
    }
}
```

### E2E Testing (Playwright)

```typescript
describe('Employee Module E2E', () => {
  let page: Page;

  beforeAll(async () => {
    browser = await chromium.launch();
    page = await browser.newPage();
  });

  afterAll(async () => {
    await browser.close();
  });

  it('user can login and navigate to employee list', async () => {
    // Navigate to login
    await page.goto('http://localhost:4200/login');

    // Fill login form
    await page.fill('input[name="email"]', 'user@test.com');
    await page.fill('input[name="password"]', 'password123');
    await page.click('button:has-text("Login")');

    // Wait for navigation to employee list
    await page.waitForURL('**/employees');

    // Verify employee list is displayed
    const heading = await page.locator('h1').textContent();
    expect(heading).toContain('Employee List');
  });

  it('user can create new employee', async () => {
    // Navigate to employee module
    await page.click('a:has-text("Employees")');
    await page.click('button:has-text("Add Employee")');

    // Fill form
    await page.fill('input[name="firstName"]', 'Jane');
    await page.fill('input[name="lastName"]', 'Smith');
    await page.fill('input[name="email"]', 'jane@example.com');
    
    // Submit
    await page.click('button:has-text("Save")');

    // Verify success message
    await expect(page.locator('[role="alert"]')).toContainText('Employee created successfully');
  });
});
```

### Test Coverage Requirements

| Layer | Coverage Requirement | Tools |
|-------|-------------------|-------|
| Backend (Domain & Application) | ≥80% | xUnit, Moq |
| Backend (Integration) | ≥70% | TestContainers, WebApplicationFactory |
| Frontend (Components) | ≥70% | Jest, Testing Library |
| Frontend (Services) | ≥80% | Jest |
| E2E (Critical Paths) | 100% | Playwright |

**CI/CD Gates**: Build fails if coverage < 80% (configurable)

---

## 📦 Deployment & DevOps

### Azure DevOps CI/CD Pipeline Structure

#### Build Stage
```yaml
trigger:
  - main
  - develop

pool:
  vmImage: 'ubuntu-latest'

variables:
  buildConfiguration: 'Release'
  dotnetVersion: '10.0.x'
  nodeVersion: '20.x'

stages:
  - stage: Build
    displayName: 'Build Application'
    jobs:
      - job: BuildBackend
        displayName: 'Build .NET API'
        steps:
          - task: UseDotNet@2
            inputs:
              version: $(dotnetVersion)
          - script: dotnet build --configuration $(buildConfiguration)
            displayName: 'Build Solution'
          - task: PublishBuildArtifacts@1
            inputs:
              pathToPublish: '$(Build.ArtifactStagingDirectory)'
              artifactName: 'api-build'

      - job: BuildFrontend
        displayName: 'Build Angular Application'
        steps:
          - task: UseNode@1
            inputs:
              version: $(nodeVersion)
          - script: npm ci
            displayName: 'Install Dependencies'
          - script: npm run build -- --configuration production
            displayName: 'Build Production Bundle'
          - task: PublishBuildArtifacts@1
            inputs:
              pathToPublish: 'dist/'
              artifactName: 'angular-build'
```

#### Test Stage
```yaml
- stage: Test
  displayName: 'Run Tests & Coverage'
  dependsOn: Build
  jobs:
    - job: BackendTests
      displayName: 'Backend Unit & Integration Tests'
      steps:
        - task: UseDotNet@2
          inputs:
            version: $(dotnetVersion)
        - script: dotnet test --configuration Release /p:CollectCoverageMetrics=true
          displayName: 'Run Tests with Coverage'
        - task: PublishCodeCoverageResults@1
          inputs:
            codeCoverageTool: 'Cobertura'
            summaryFileLocation: '$(Agent.TempDirectory)/**/coverage.xml'

    - job: FrontendTests
      displayName: 'Frontend Unit Tests'
      steps:
        - task: UseNode@1
          inputs:
            version: $(nodeVersion)
        - script: npm ci
        - script: npm run test:ci -- --coverage
          displayName: 'Run Jest Tests with Coverage'
        - task: PublishCodeCoverageResults@1
          inputs:
            codeCoverageTool: 'Cobertura'
```

#### Deploy to Staging
```yaml
- stage: DeployStaging
  displayName: 'Deploy to Staging'
  dependsOn: Test
  condition: succeeded()
  jobs:
    - deployment: DeployAPI
      displayName: 'Deploy API to Staging'
      environment: 'staging'
      strategy:
        runOnce:
          deploy:
            - task: AzureWebApp@1
              inputs:
                azureSubscription: 'Azure Subscription'
                appName: 'hrm-api-staging'
                package: '$(Pipeline.Workspace)/api-build/**/*.zip'

    - deployment: DeployWeb
      displayName: 'Deploy Web App to Staging'
      environment: 'staging'
      strategy:
        runOnce:
          deploy:
            - task: AzureWebApp@1
              inputs:
                azureSubscription: 'Azure Subscription'
                appName: 'hrm-web-staging'
                package: '$(Pipeline.Workspace)/angular-build/**/*.zip'
```

### Docker Compose for Local Development

```yaml
version: '3.8'

services:
  mssql:
    image: mcr.microsoft.com/mssql/server:2022-latest
    environment:
      ACCEPT_EULA: 'Y'
      SA_PASSWORD: 'Password@123!'
      MSSQL_PID: 'Developer'
    ports:
      - '1433:1433'
    volumes:
      - mssql_data:/var/opt/mssql/data
    healthcheck:
      test: ['CMD', '/opt/mssql-tools/bin/sqlcmd', '-S', 'localhost', '-U', 'sa', '-P', 'Password@123!', '-Q', 'SELECT 1']
      interval: 10s
      timeout: 5s
      retries: 5

  redis:
    image: redis:7-alpine
    ports:
      - '6379:6379'
    healthcheck:
      test: ['CMD', 'redis-cli', 'ping']
      interval: 10s
      timeout: 5s
      retries: 5

  api:
    build:
      context: ..
      dockerfile: docker/Dockerfile.api
    ports:
      - '5001:8080'
    environment:
      ASPNETCORE_ENVIRONMENT: 'Development'
      ConnectionStrings__DefaultConnection: 'Server=mssql;Database=HrmDb;User Id=sa;Password=Password@123!;'
      RedisSettings__ConnectionString: 'redis:6379'
    depends_on:
      mssql:
        condition: service_healthy
      redis:
        condition: service_healthy

  angular:
    build:
      context: ../src/hrm-angular
      dockerfile: ../../docker/Dockerfile.angular
    ports:
      - '4200:80'
    environment:
      API_URL: 'http://api:8080'
    depends_on:
      - api

volumes:
  mssql_data:
```

### Environment Configuration

**Development (Local)**
- SQL Server: Localhost with Windows authentication
- Redis: Local cache
- Swagger: Enabled
- CORS: Relaxed
- Logging: Debug level

**Staging**
- SQL Server: Azure SQL Database
- Redis: Azure Cache for Redis
- Swagger: Disabled
- CORS: Specific origins
- Logging: Information level

**Production**
- SQL Server: Azure SQL Database (HA replicas)
- Redis: Azure Cache for Redis (Premium)
- Swagger: Disabled
- CORS: Strict origins
- Logging: Warning level
- Application Insights: Enabled

---

## 👥 Contributing Guidelines

### Code Style & Standards

#### C# Naming Conventions
```csharp
// Classes and Public Members: PascalCase
public class EmployeeService { }
public string FirstName { get; set; }

// Private Members: camelCase with underscore prefix
private string _internalValue;
private IRepository<Employee> _repository;

// Constants: UPPER_CASE
private const int MAX_EMPLOYEES = 1000;

// Local Variables: camelCase
var employeeList = await _repository.GetAllAsync();
```

#### TypeScript/Angular Style
```typescript
// Components, Services: UpperCamelCase
export class EmployeeListComponent { }
export class EmployeeService { }

// Variable, methods: camelCase
public employeeList: Employee[] = [];
public getEmployeeById(id: number): Employee { }

// Constants: UPPER_SNAKE_CASE
export const MAX_RETRY_ATTEMPTS = 3;

// Interfaces: prefix with 'I'
export interface IEmployee { }
```

### Git Workflow

#### Branch Naming
```bash
feature/employee-management        # New feature
bugfix/login-validation-error      # Bug fix
hotfix/critical-production-issue   # Critical production fix
refactor/improve-performance       # Refactoring
```

#### Commit Message Format
```
<type>(<scope>): <subject>

<body>

<footer>
```

**Types**: `feat`, `fix`, `docs`, `style`, `refactor`, `perf`, `test`, `chore`  
**Scopes**: `employee`, `leave`, `payroll`, `auth`, `api`, `ui`, etc.

**Example**:
```
feat(employee): add bulk employee import

- Implement BulkImportCommand handler
- Create Excel file parser service
- Add validation for duplicate employees
- Generate import summary report

Closes #123
```

### Pull Request Process

1. **Create Feature Branch**
   ```bash
   git checkout -b feature/my-feature
   ```

2. **Implement & Test**
   - Write code following style guide
   - Add unit/integration tests
   - Ensure >80% coverage

3. **Push & Create PR**
   ```bash
   git push origin feature/my-feature
   ```

4. **PR Requirements**
   - Clear description of changes
   - Link to related issues (#123)
   - Pass all CI/CD checks
   - ≥1 code review approval
   - No merge conflicts

5. **Merge**
   ```bash
   # Squash commits for cleaner history
   git merge --squash feature/my-feature
   ```

### Code Quality Tools

```bash
# C# - Format & analyze code
dotnet format
dotnet analyze

# TypeScript - ESLint & Prettier
npm run lint
npm run format

# Run all checks
npm run quality:check  # Frontend
dotnet quality:check   # Backend
```

---

## 📞 Team & Support

### Key Contacts
- **Tech Lead**: [Your Name]
- **Product Owner**: [Your Name]
- **DevOps Engineer**: [Your Name]

### Documentation Links
- 📖 [System Architecture](./docs/architecture.md)
- 🔌 [API Conventions](./docs/api-conventions.md)
- 🗄️ [Database Schema Guide](./docs/database-migrations.md)
- 🚀 [Deployment Guide](./docs/deployment-guide.md)
- 🐛 [Troubleshooting](./docs/troubleshooting.md)

### Communication Channels
- 💬 **Slack**: `#hrm-development` channel
- 📧 **Email**: `hrm-team@company.com`
- 🐛 **Issues**: GitHub/Azure DevOps issue tracker
- 📅 **Meetings**: Weekly sync every Monday 10 AM

---

## 🚦 Quick Troubleshooting

### Common Issues & Solutions

#### Database Connection Failed
```
Error: Cannot connect to SQL Server
Solution:
1. Verify SQL Server is running: sqlcmd -S localhost -U sa
2. Check connection string in appsettings.Development.json
3. Ensure database exists: CREATE DATABASE HrmDb
4. Apply migrations: dotnet ef database update
```

#### JWT Token Expired
```
Error: 401 Unauthorized
Solution:
1. Call /api/v1/auth/refresh-token with refresh token
2. Update localStorage with new access token
3. Retry original request
```

#### Angular Build Failure
```
Error: npm run build fails
Solution:
1. Clear node_modules: rm -rf node_modules package-lock.json
2. Reinstall dependencies: npm install
3. Clear Angular cache: ng cache clean
4. Try build again: ng build
```

#### API Swagger UI Not Loading
```
Error: https://localhost:5001/swagger returns 404
Solution:
1. Ensure Swagger middleware is registered in Program.cs
2. Check if ASPNETCORE_ENVIRONMENT is set correctly
3. Verify Swagger NuGet package is installed
4. Restart API server
```

---

## 📊 Project Statistics

| Metric | Value |
|--------|-------|
| **Total Phases** | 10 |
| **Estimated Timeline** | 14-15 weeks |
| **Backend Projects** | 4 (.NET 10) |
| **Frontend Modules** | 5+ (Angular 21+) |
| **Test Projects** | 3 (Unit, Integration, E2E) |
| **Database Tables** | 8+ core tables |
| **API Endpoints** | 30+ RESTful endpoints |

---

## 📄 License

This project is licensed under the **MIT License**. See [LICENSE](./LICENSE) file for details.

---

## 🎯 Useful References & Commands

### Backend Quick Commands
```bash
# Create new migration
dotnet ef migrations add AddNewColumn --project src/HRM.Infrastructure

# Update database to latest migration
dotnet ef database update

# Revert last migration
dotnet ef migrations remove

# Run unit tests
dotnet test --filter "Category=Unit"

# Run integration tests
dotnet test --filter "Category=Integration"

# Build release package
dotnet publish -c Release -o ./publish

# Code analysis
dotnet analyze
dotnet format --verify-no-changes
```

### Frontend Quick Commands
```bash
# Generate new component
ng generate component features/employee/employee-list

# Generate new service
ng generate service core/auth/auth

# Run tests in watch mode
ng test

# Run tests with coverage
ng test --code-coverage

# Build for production
ng build --configuration production

# Analyze bundle size
ng build --stats-json
webpack-bundle-analyzer dist/hrm-angular/stats.json
```

### Docker Commands
```bash
# Build image
docker build -f docker/Dockerfile.api -t hrm-api:latest .

# Run container
docker run -p 5001:8080 hrm-api:latest

# View logs
docker logs -f container_id

# Stop container
docker stop container_id

# Cleanup dangling images
docker image prune -a
```

---

## 📝 Last Updated

- **Version**: 1.0.0
- **Last Update**: January 2024
- **.NET Version**: 10.0+
- **Angular Version**: 21+
- **Status**: 🟢 Active Development

For latest updates and comprehensive documentation, visit:
- 🌐 [GitHub Repository](https://github.com/your-org/MXHRM)
- 📚 [Documentation Site](https://docs.yourdomain.com/hrm)
- 🐛 [Issue Tracker](https://github.com/your-org/MXHRM/issues)

---

**Made with ❤️ by the MXHRM Development Team**
