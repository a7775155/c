                         📚MyLibrary Desktop Application 
 
=> Event-Driven Programming with C# - Individual Assignment

✨ Overview
Welcome to MyLibrary, a robust and intuitive Windows desktop application meticulously crafted to streamline the management of a small library's book inventory and member borrowing records. Developed with C# and WinForms, this project is a practical demonstration of core software engineering principles, including event-driven programming, user-centric UI design, and seamless database integration via ADO.NET.

Whether you're a budding librarian seeking an efficient management tool or a developer eager to explore the intricacies of C# desktop applications with persistent data storage, MyLibrary offers a clear, functional, and well-structured example.

🚀 Key Features
MyLibrary empowers you with a comprehensive suite of functionalities to manage your library operations with ease:

🔐 Secure User Authentication:

A dedicated login form ensures controlled access by authenticating users against a Users table in the database.

🖥️ Intuitive Main Interface:

A clean, tabbed interface (Books Management and Borrowers Management) provides logical separation and effortless navigation.

📖 Books Management Module:

Dynamic Book List: View a sortable and readable list of all books, displaying key details like BookID, Title, Author, Year, and AvailableCopies.

➕ Add New Books: Dedicated form for adding new book entries to your inventory.

✏️ Edit Existing Books: Select any book from the list to open a pre-populated form for quick and easy modifications.

🗑️ Delete Books: Safely remove book records with a clear confirmation prompt, preventing accidental deletions.

✅ Robust Input Validation: Ensures data integrity for all book details, including checks for non-empty fields and valid numeric ranges.

👥 Borrowers Management Module:

Comprehensive Borrower List: Browse a sortable list of all registered library members, showing BorrowerID, Name, Email, and Phone.

➕ Register New Borrowers: Form for registering new library members.

✏️ Update Borrower Details: Select a borrower to edit their information via a pre-populated form.

🗑️ Remove Borrowers: Securely delete borrower records with a confirmation, respecting data integrity constraints.

➡️ Issue Books: Facilitates recording new book loans, automatically decrementing AvailableCopies and logging the transaction in the IssuedBooks table with IssueDate and DueDate.

⬅️ Return Books: Processes book returns, incrementing AvailableCopies for the returned book and updating/flagging the corresponding record in the IssuedBooks table.

📊 (Bonus) Reporting & Filtering Capabilities:

🔍 Advanced Book Filtering: Easily filter your book inventory by specific authors or within a defined year range.

⏰ Overdue Books Report: Generate a simple report highlighting all books whose DueDate has passed, helping you manage outstanding loans.

⚙️ Technical Stack
This application is built upon a solid foundation of modern Microsoft technologies and database practices:

Language: C#

Framework: .NET Framework (Windows Forms - WinForms)

Database: MySQL (Highly configurable; supports LocalDB or SQLite by simply adjusting the connection string in the C# code).

Data Access: ADO.NET, utilizing parameterized queries to ensure robust security against SQL injection attacks and efficient data interaction.

Event Handling: Comprehensive use of standard WinForms event handlers (Click, SelectionChanged, TextChanged, FormClosing, Load) for a highly responsive and interactive user experience.

Exception Handling: Implements try-catch blocks throughout all database calls to gracefully manage errors, providing informative and user-friendly dialogs rather than crashes.

Input Validation: Features comprehensive validation rules to ensure data quality, including checks for non-empty fields, correct numeric ranges, and valid email formats.

🚀 Getting Started: Your First Steps
Follow these detailed instructions to set up and run the MyLibrary application on your local development environment.

Prerequisites:
Before you begin, ensure you have the following installed:

Visual Studio: Version 2019 or newer is recommended. Make sure the ".NET desktop development" workload is selected during installation.

MySQL Server: A running instance of MySQL Server (e.g., MySQL 8.0).

MySQL.Data NuGet Package: This essential ADO.NET connector for MySQL will be automatically restored by Visual Studio when you build the solution. Ensure your system has access to NuGet.org.

Installation & Setup Guide:
Clone the Repository:
Start by cloning the project to your local machine using Git:

git clone <your-github-repo-link>
cd MyLibraryApp

Database Setup:
This is a crucial step to prepare your backend.

Open your preferred MySQL client (e.g., MySQL Workbench, phpMyAdmin, or your command line tool).

Execute the comprehensive SQL script located at MyLibraryBD.sql in the root of the cloned repository. This script will:

Create the mylibrarydb database (if it doesn't already exist).

Define the complete schema for all application tables: Users, Books, Borrowers, and IssuedBooks.

Establish crucial FOREIGN KEY constraints to maintain data integrity and relationships between your tables.

Populate the tables with initial sample data, allowing you to immediately test the application's functionalities.

⚠️ IMPORTANT: Update Connection Strings!
After setting up the database, you must update the connectionString variable within the C# code files (Forms/LoginForm.cs, Forms/MainForm.cs, and other forms) to accurately reflect your specific MySQL server credentials (server address, port, database name, username, and password).

// Example connection string in C# files (adjust for your setup):
private string connectionString = "Server=localhost;Port=3306;Database=mylibrarydb;Uid=root;Pwd=mySecurePassword;";

Open in Visual Studio:

Navigate to the cloned repository folder and open the MyLibraryApp.sln solution file in Visual Studio.

Build the Solution:

In Visual Studio, go to the Build menu and select Build Solution (or simply press Ctrl+Shift+B). This process will automatically restore any required NuGet packages and compile the entire application.

Run the Application:

Once the build is successful, press F5 or click the green Start button in Visual Studio's toolbar. The MyLibrary Login Form should now appear, ready for use!

🔑 Default Login Credentials
For your convenience during initial testing, the database is pre-seeded with the following administrative credentials:

Username: admin

Password: password123

📸 UI Screenshots
A comprehensive collection of screenshots showcasing the application's key screens and user flows will be made available in the docs/screenshots/ folder. This will provide a visual guide to MyLibrary's interface and functionality.

docs/screenshots/login_form.png

docs/screenshots/main_form_books.png

docs/screenshots/main_form_borrowers.png

docs/screenshots/book_form_add.png

docs/screenshots/book_form_edit.png

docs/screenshots/borrower_form_add.png

docs/screenshots/borrower_form_edit.png

docs/screenshots/issue_return_flow.png

📂 Repository Structure
The project is organized into a clear and logical directory structure, adhering to best practices for maintainability and scalability:

MyLibraryApp/
├── MyLibraryApp.sln             # ➡️ The main Visual Studio Solution File
├── MyLibraryApp/                # 📂 The core C# Project Folder
│   ├── App.config               #    Application-wide configuration settings
│   ├── Program.cs               #    Application's entry point (starts LoginForm)
│   ├── Forms/                   #    📁 Directory for all UI Forms
│   │   ├── LoginForm.cs         #       Login Form (C# Code-Behind for logic)
│   │   ├── LoginForm.Designer.cs#       Login Form (Auto-generated UI design code)
│   │   ├── LoginForm.resx       #       Login Form (UI resources)
│   │   ├── MainForm.cs          #       Main Application Form (C# Code-Behind for logic)
│   │   ├── MainForm.Designer.cs #       Main Application Form (Auto-generated UI design code)
│   │   ├── MainForm.resx        #       Main Application Form (UI resources)
│   │   ├── BookForm.cs          #       Form for adding/editing Books
│   │   ├── BookForm.Designer.cs #       BookForm (Designer-Generated Code)
│   │   ├── BookForm.resx        #       BookForm (Resources)
│   │   ├── BorrowerForm.cs      #       Form for adding/editing Borrowers
│   │   ├── BorrowerForm.Designer.cs #   BorrowerForm (Designer-Generated Code)
│   │   ├── BorrowerForm.resx    #       BorrowerForm (Resources)
│   │   ├── IssueReturnForm.cs   #       Form for Issue/Return operations
│   │   ├── IssueReturnForm.Designer.cs # IssueReturnForm (Designer-Generated Code)
│   │   └── IssueReturnForm.resx #       IssueReturnForm (Resources)
│   ├── Data/                    #    📁 Directory for data access related classes
│   │   └── DatabaseHelper.cs    #       Helper class for database operations
│   └── ... (bin/, obj/, Properties/ folders for build outputs and project settings)
├── MyLibraryBD.sql              # 🗄️ SQL script for database creation and initial data (at the root level)
└── docs/                        # 📄 Documentation and assets
    └── screenshots/             #    Directory for UI screenshots
        ├── login_form.png
        └── ... (other screenshots)
└── README.md                    # 📖 This comprehensive README file

📄 Database Script (MyLibraryBD.sql)
This critical SQL file is your one-stop solution for database initialization:

It intelligently creates the mylibrarydb database if it does not already exist.

It meticulously defines the schema for all core application tables: Users, Books, Borrowers, and IssuedBooks.

It establishes robust FOREIGN KEY constraints, ensuring referential integrity and consistency across your related data.

It populates the tables with essential initial sample data, enabling you to immediately test and interact with the application upon setup.

🚧 Challenges Faced
Developing the MyLibrary application presented several common yet insightful challenges, typical of WinForms desktop applications with database integration:

Database Connectivity & Configuration: Establishing a stable and secure connection to the MySQL database, especially managing connection strings and ensuring proper MySQL.Data NuGet package integration across different parts of the application.

ADO.NET Data Operations: Implementing robust CRUD (Create, Read, Update, Delete) operations using ADO.NET required careful handling of MySqlConnection, MySqlCommand, and MySqlDataReader/MySqlDataAdapter objects. Ensuring proper disposal of resources (e.g., using using statements) was crucial to prevent resource leaks.

Parameterized Queries: A significant challenge was consistently using parameterized queries to prevent SQL injection vulnerabilities, requiring careful construction of SQL commands for every database interaction.

UI Threading and Responsiveness: For longer-running database operations, ensuring the UI remained responsive without freezing the application required consideration of asynchronous patterns (though simpler solutions like background workers might suffice for basic operations).

Data Binding and Refreshing DataGridViews: Efficiently displaying and refreshing data in DataGridView controls after database changes (add, edit, delete, issue, return) without flickering or performance issues. This involved effectively using MySqlDataAdapter and DataTable to update the UI.

Input Validation Logic: Implementing comprehensive client-side input validation on various form fields (e.g., checking for empty strings, numeric-only input, valid email formats, year ranges, and positive available copies) to ensure data quality before submission to the database.

Foreign Key Constraints: Managing database relationships (e.g., preventing deletion of a book if it's currently issued or a borrower with active loans) required implementing ON DELETE RESTRICT in SQL and handling associated exceptions gracefully in the C# code.

Error Handling and User Feedback: Providing clear, actionable error messages to the user for both application logic errors and database-related exceptions, rather than showing cryptic system errors.

Source: Gemini AI
