# ✅ TodoList Fullstack

> A modern task management application built with .NET Minimal API & React

[![.NET](https://img.shields.io/badge/.NET-Core-purple?logo=dotnet)](https://dotnet.microsoft.com/)
[![React](https://img.shields.io/badge/React-18-blue?logo=react)](https://reactjs.org/)
[![MySQL](https://img.shields.io/badge/MySQL-Database-orange?logo=mysql)](https://www.mysql.com/)

## 🌐 Live Demo

🚀 **[Try the Live App](https://task-manager-client-8g71.onrender.com/)** - Experience the TodoList in action!

> **Note:** Hosted on Render's free tier - may take a moment to wake up on first visit.

## 🌟 Features

- ✅ **Task Management** - Create, edit, delete and mark tasks as complete
- 🚀 **Minimal API** - Lightweight .NET backend
- 🗄️ **MySQL Database** - Entity Framework integration
- 📱 **Responsive Design** - Works on all devices
- 📊 **Swagger Documentation** - Interactive API docs

## 🛠️ Tech Stack

**Backend:** .NET 6+ Minimal API, Entity Framework Core, MySQL  
**Frontend:** React, Axios, HTML/CSS  
**Tools:** Swagger, CORS, EF Scaffolding

## 🚀 Quick Start

> 💡 **Want to try it first?** Check out the [**Live Demo**](https://task-manager-client-8g71.onrender.com/) before setting up locally!

### Prerequisites
- .NET 6+ SDK
- Node.js 16+
- MySQL Server

### Setup
```bash
# 1. Setup Database
CREATE DATABASE ToDoDB;
CREATE TABLE Items (
    Id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(100),
    IsComplete TINYINT(1) DEFAULT 0
);

# 2. Backend Setup
cd TodoApi
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Pomelo.EntityFrameworkCore.MySql
dotnet ef dbcontext scaffold Name=ToDoDB Pomelo.EntityFrameworkCore.MySql -f -c ToDoDbContext
dotnet watch run

# 3. Frontend Setup
cd ToDoListReact
npm install
npm start
```

## 📁 Project Structure

```
task-manager/
├── TodoApi/              # .NET Minimal API Backend
│   ├── Program.cs        # API routes & configuration
│   └── appsettings.json  # Database connection
└── ToDoListReact/        # React Frontend
    └── src/services/     # API communication
```

## 🔌 API Endpoints

- `GET /api/items` - Get all tasks
- `POST /api/items` - Create task
- `PUT /api/items/{id}` - Update task
- `DELETE /api/items/{id}` - Delete task

Visit `/swagger` for interactive documentation.

## 🚀 Deployment

Deployed on Render with frontend as static site and backend as web service.

## 🔮 Future Enhancements

- 🔐 JWT Authentication
- 👥 Multi-user support
- 🏷️ Categories & Tags
- 📅 Due dates

## 👩‍💻 Author

**Batya** - [GitHub](https://github.com/Batya19)

---

<div align="center">
  <b>Made with ❤️ for productive task management</b>
</div>