# 👨‍💼 Employee Management API

## 📌 Project Overview

The **Employee Management API** is a backend application developed using **ASP.NET Core Web API**.

This project focuses on building **RESTful APIs** to manage employee data efficiently. Instead of a frontend UI, **Swagger UI** is used for API documentation and testing.

---

## 🎯 Key Features

* ✅ Create employee records (**POST**)
* 📋 Retrieve all employees (**GET**)
* 🔍 Retrieve employee by ID (**GET by Id**)
* ✏️ Update employee details (**PUT**)
* ❌ Delete employee records (**DELETE**)
* 🌐 RESTful API architecture
* 📘 Swagger UI for API testing

---

## 🧪 API Testing using Swagger

* Swagger provides an **interactive UI to test APIs directly from browser**
* Displays all available endpoints with request & response formats
* Allows executing API methods without frontend

👉 Swagger automatically generates API documentation and enables testing from browser 

---

## 🛠️ Technologies Used

* 💻 C#
* 🌐 ASP.NET Core Web API
* 🗄️ SQL Server
* 🔄 Entity Framework Core
* 📘 Swagger (OpenAPI)

---

## ⚙️ API Endpoints

| Method | Endpoint            | Description         |
| ------ | ------------------- | ------------------- |
| GET    | /api/Employees      | Get all employees   |
| GET    | /api/Employees/{id} | Get employee by ID  |
| POST   | /api/Employees      | Create new employee |
| PUT    | /api/Employees/{id} | Update employee     |
| DELETE | /api/Employees/{id} | Delete employee     |

---

## 🧠 Project Architecture

The project follows a clean backend architecture:

* **Controller** → Handles HTTP requests
* **Model** → Represents employee data
* **DbContext** → Manages database operations

---

## 🚀 How to Run the Project

1. Clone the repository:

   ```bash
   git clone https://github.com/yourusername/EmployeeAdmPortal.git
   ```

2. Open in **Visual Studio**

3. Configure database in:

   ```
   appsettings.json
   ```

4. Run migrations:

   ```bash
   Update-Database
   ```

5. Run the application (F5)

6. Open Swagger:

   ```
   https://localhost:xxxx/swagger
   ```

---

## 💡 Key Learning

* Developed RESTful APIs using ASP.NET Core
* Implemented CRUD operations using Entity Framework Core
* Learned API documentation and testing using Swagger
* Understood backend architecture and data handling

---

## 📈 Future Enhancements

* Add frontend (React / Angular)
* Implement authentication (JWT)
* Add pagination and filtering
* Deploy to cloud (Azure)

---

## 👩‍💻 Author

**Ramya Dasari**
Aspiring .NET Developer

---

## ⭐ Conclusion

This project demonstrates strong understanding of:

* Backend API development
* CRUD operations
* REST architecture
* API documentation using Swagger

👉 This project can be integrated with any frontend application, making it scalable and reusable.

[1]: https://dev.to/neon-postgres/building-a-restful-api-with-aspnet-core-swagger-and-neon-9el?utm_source=chatgpt.com "Building a RESTful API with ASP.NET Core, Swagger, and ..."
