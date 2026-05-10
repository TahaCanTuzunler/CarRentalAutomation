# Car Rental Automation System

This project is a desktop-based management software developed to streamline the operational processes of a car rental business. It serves as a practical implementation of data access technologies, utilizing both ADO.NET and Entity Framework 6.0 within a single C# WinForms application.

## Project Description
The system allows a car rental company to track its vehicle fleet, manage customer records, and handle rental transactions digitally. Developed as part of Management Information Systems (MIS) coursework, the project focuses on relational database design and tiered architecture principles.

## Key Features
- Secure authentication system for authorized administrators.
- Comprehensive vehicle management: Add, update, delete, and list vehicles.
- Customer relationship management: Registration and tracking of customer data.
- Rental transaction processing: Managing rentals based on vehicle availability.
- Real-time data monitoring via list views and data grids.

## Technology Stack
- Programming Language: C#
- Application Type: Windows Forms (WinForms)
- Database: Microsoft SQL Server (MSSQL)
- Data Access Methods: Entity Framework 6.0 and ADO.NET
- Query Technologies: LINQ and T-SQL

## Database Architecture
The application relies on a relational database schema hosted on SQL Server. Data integrity is maintained through primary and foreign key constraints. A comprehensive SQL script is included in the project directory, containing the full schema definition and sample data for testing.

## Installation and Setup
To run this project on your local machine, please follow these steps:

1. Clone or download the repository to your local directory.
2. Open Microsoft SQL Server Management Studio (SSMS).
3. Open and execute the provided SQL script file (.sql) to create the database, tables, and sample records.
4. Open the solution file (.sln) in Visual Studio.
5. Navigate to the App.config file and update the connection string to match your local SQL Server instance name (e.g., .\SQLEXPRESS).
6. Build the solution and run the application.

## Screenshots
Visual representations of the user interface, including the login screen and management dashboards, are available in the media directory of the project.

## Contact
Developed by: Taha Can Tuzunler
Email: tahacantznler@gmail.com
LinkedIn: linkedin.com/in/tahacantuzunler
