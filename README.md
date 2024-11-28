# Taskama

Taskama is a task management application developed using **ASP.NET** for the backend and **Angular** for the frontend. The application helps users create, manage, and track task progress efficiently.

---

## 🚀 Key Features

- **Task Management**: Add, edit, delete, and view task details.
- **Task Categorization**: Attach labels, set priorities, and sort tasks by deadline.
- **Modern Interface**: Designed with Angular Material, supporting dark mode.
- **Authentication System**: Secure registration and login with JWT.
- **RESTful API**: Data connection through ASP.NET Web API.

---

## 📂 Project Structure

```plaintext
Taskama/
├── server/               # ASP.NET Core API
│   ├── Controllers/       # API Controllers
│   ├── Models/            # Data Models
│   ├── Services/          # Logic Processing Services
│   └── Repositories/      # Database Interaction Handling
│
├── client/              # Angular Frontend
│   ├── src/
│   │   ├── app/           # Components, services, modules
│   │   ├── assets/        # Images, CSS files
│   │   └── environments/  # Environment configurations
│   └── angular.json       # Angular configuration
│
├── README.md              # Usage instructions
└── LICENSE.md             # License information
```

---
## ⚙️ System Requirements
**Server**:
- .NET SDK 6.0 or newer.
- PostgreSQL
**Client**:
- Node.js 18 or newer.
- Angular CLI 15+.
---
## 🛠️ Installation and Running the Project
**1. Clone repository**
```bash
git clone https://github.com/HTDuan0246/taskama.git
cd taskama
```
**2. Install server**
```bash
cd server
dotnet restore
dotnet run
```
API will run at ```http://localhost:5000```.

**3. Install client**
```bash
cd client
npm install
ng serve
```
Client will run at ```http://localhost:4200```.

---
## 🌟 Planned Interface

**Dashboard - Task Management**
- Display task list with basic information (name, deadline, status).
- Allow creating, editing, or deleting tasks.

**Task Details - Task Details**
- View detailed information for each task.
- Change status or update information.

---
## 📜 License
This project is licensed under the [MIT License](LICENSE).

---
## ✨ Contributing
**If you want to contribute to the project:**

- Fork this repository.
- Create a new branch: ```git checkout -b feature/your-feature```.
- Commit your changes: ```git commit -m "Add your feature"```.
- Push your branch: ```git push origin feature/your-feature```.
- Create a Pull Request.

---
## 📧 Contact
For any questions or suggestions, please contact via email: duanhotrong@gmail.com.
