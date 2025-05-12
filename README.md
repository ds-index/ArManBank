# 🏦 ArManBank - User Bank Account Management System

A cross-platform **EF Core (Code-First)** console application designed to manage user bank accounts.

---

## ✨ Features

- ✅ Built with **Entity Framework Core (Code First)**
- ✅ **Cross-platform**: Runs on Windows, Linux, and macOS
- ✅ Modular structure using class libraries
- ✅ Core banking operations:
  - User registration & login
  - Account creation
  - Deposit & withdrawal
  - Balance inquiries
- ✅ Developed in **C#** with **.NET Core**

---

## 🔧 Technologies Used

| Technology    | Version |
|---------------|---------|
| .NET Core      | 6.0+    |
| C#             | 10+     |
| EF Core        | 7.x     |
| LINQ           | ✅       |
| SQLite / SQL Server | Supported |

---

## 🚀 Getting Started

### 1. Clone the Repository

```bash
git clone https://github.com/YourUsername/ArManBank.git
cd ArManBank
```
2. Apply Migrations & Create Database
```bash
dotnet ef database update
```
Note: If dotnet ef is not installed, run dotnet tool install --global dotnet-ef.
```bash
dotnet run
```
## 📁 Project Structure
ArManBank/
│
├── ArManBank.Console/ ← Main console app
├── ArManBank.Domain/ ← Entities and models
├── ArManBank.Data/ ← DbContext & EF migrations
├── ArManBank.Services/ ← Business logic layer
└── README.md ← This file

💡 Educational Purpose
This project is intended to demonstrate and practice:

Using EF Core with Code First approach

Clean architecture with separated layers

Real-world banking scenarios in a console environment

Extensibility and SOLID principles

🔐 Security Tips
Avoid storing sensitive data (like connection strings) in appsettings.json.

Use User Secrets or environment variables for local development.

🧩 Contributing
Feel free to contribute! 🌱
Open an issue or submit a pull request if you have suggestions or improvements.

📄 License
MIT License – free for personal and educational use.

👨‍💻 Author
Built with ❤️ by ArManDS
