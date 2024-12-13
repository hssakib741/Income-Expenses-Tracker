Income-Expenses Tracker (C# Project)
The Income-Expenses Tracker is a desktop application built in C# with a Windows Forms interface to help users efficiently manage their financial records. The application integrates with a SQL database to securely store income and expense data, categorize transactions, and generate summaries for better financial insights.

Key Features
Admin Dashboard:

Centralized view to manage income, expenses, categories, and user registrations.
Admin Registration:

Secure admin registration and authentication to access the system.
Income Tracking:

Input and manage various income sources.
Store income data with timestamps and categories.
Expense Tracking:

Log expenses with detailed descriptions and categories.
View and filter expense records by date or category.
Category Management:

Create and manage custom categories for income and expenses.
Data Visualization:

Dashboard displaying summary charts and graphs of financial data.
SQL Integration:

All data stored in a SQL database using SQL queries for CRUD (Create, Read, Update, Delete) operations.
Forms and UI:

Multiple Windows Forms for user interaction:
AdminMain: Main form for administrators.
DashboardForm: Financial overview.
IncomeForm: Manage income records.
ExpenseForm: Manage expenses.
CategoryForm: Category management.
RegisterForm: Admin registration and login.
Technology Used
Language: C# (Windows Forms).
Database: SQL (Connected using ADO.NET for SQL queries).
Project Files:
AdminMain.cs: Handles admin-related functionalities.
CategoryForm.cs: Manages categories for transactions.
IncomeForm.cs: Handles income records.
ExpenseForm.cs: Handles expense records.
DashboardForm.cs: Displays data summaries and visualizations.
Program.cs: Entry point of the application.
