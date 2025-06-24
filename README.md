# Library Management System (LMS)

## Description

The Library Management System (LMS) is a comprehensive application designed to help library staff and students manage books, borrowing, returning, and book supplies. The system allows students to log in, borrow and return books, and view their transaction history, while administrators can manage users, books, and supplies. The application uses a SQL Server database to handle data persistence and real-time updates.

## Features

* **User Authentication:** Login system for students and administrators.
* **Book Management:** Admins can add, edit, and manage books in the library system.
* **Borrowing and Returning Books:** Students can borrow and return books, and view their transaction history.
* **Book Supply Management:** Admins can manage book supplies and stock levels.
* **Reports:** Admins can generate reports on book supply and borrow transactions.
* **Database Integration:** All data is stored and managed in a SQL Server database.

## Technologies Used

* **Frontend:** Windows Forms (C#)
* **Backend:** C#
* **Database:** SQL Server
* **Programming Language:** C#
* **Development Environment:** Visual Studio

## Getting Started

### Prerequisites

* Install [Visual Studio](https://visualstudio.microsoft.com/) (preferably the Community Edition)
* SQL Server installed and running
* A SQL Server connection string (modify the `DatabaseHandler.GetNewConnection()` method with your connection details)

### Installation

1. Clone this repository:

   ```
   git clone https://github.com/your-username/library-management-system.git
   ```
2. Open the project in Visual Studio.
3. Set up the SQL Server database:

   * Create a new database in SQL Server (e.g., `LibraryDB`).
   * Import or create the necessary tables (`Users`, `Books`, `BorrowingTransaction`, `BookReturnTransaction`, etc.) based on the system’s requirements.
4. Modify the `DatabaseHandler.GetNewConnection()` method to connect to your database.

### Usage

1. Run the project in Visual Studio.
2. **Login:**

   * Use the login screen to authenticate as either a student or admin.
3. **Admin Features:**

   * Admins can manage users, books, and supplies via the admin menu.
   * Admins can generate reports on book supply and borrow transactions.
4. **Student Features:**

   * Students can view their borrowed books, return books, and view transaction history.

## Database Schema

### Users Table

* **UserID** (Primary Key)
* **FirstName**
* **MiddleName**
* **LastName**
* **Address**
* **ContactNumber**
* **Email**
* **Username**
* **Password**
* **IsAdmin** (0 for student, 1 for admin)

### Books Table

* **BookID** (Primary Key)
* **ISBN**
* **Category**
* **Title**
* **Author**
* **Abstract**

### BorrowingTransaction Table

* **TransactionID** (Primary Key)
* **BookID**
* **UserID**
* **Quantity**

### BookReturnTransaction Table

* **ReturnTransactionID** (Primary Key)
* **BookID**
* **UserID**
* **Quantity**

## Limitations

* **Security:** Passwords are stored in plaintext. This should be addressed by implementing proper hashing and encryption.
* **Scalability:** The system may face performance issues with large datasets or complex queries.
* **User Interface:** The interface can be improved to enhance user experience and ease of use.

## Future Improvements

* Implement email notifications for overdue books.
* Add a mobile-friendly version of the system.
* Implement password encryption for security.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
