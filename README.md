🚜 Farm Equipment Rental Platform

A comprehensive Windows Forms application for managing farming equipment rentals, built using VB.NET and a SQL database.

📋 Overview

The Farm Equipment Rental Platform provides an all-in-one solution for farmers to rent equipment, access educational farming resources, and manage user profiles through an intuitive Windows Forms interface.
The system supports full CRUD (Create, Read, Update, Delete) functionality and focuses on usability, data integrity, and real-world farming needs.

✨ Features
🔐 User Management

Secure login and registration system

Password recovery functionality

User profile management

Input validation (email, phone number, required fields)

🛠️ Equipment Rental

Browse available farming equipment

Real-time pricing display (R1400 – R3000 per hour)

Checkout system with item count and total cost calculation

Equipment categories:

Tractors

Harvesters

Watering systems

Other farming machinery

📚 Educational Resources

Farming guides and tutorials

Crop lifecycle information

Modern and sustainable farming techniques

💼 Marketing & Information

Benefits of equipment hiring

Frequently Asked Questions (FAQ)

Try-before-you-buy options

Tax benefit explanations for equipment rental

🛠️ Technology Stack

Frontend: VB.NET, Windows Forms

Backend: SQL Database

Architecture: Multi-form application with CRUD operations

Validation: Custom input validation functions

Navigation: Form-to-form navigation using hide/show transitions

📁 Project Structure
GUI/
├── My Project/            # Application configuration
├── Form1.vb               # Login & Registration
├── home_page.vb           # Main dashboard
├── hirepage.vb            # Equipment rental module
├── Education.vb           # Educational content
├── FAQ.vb                 # FAQ and informational content
├── forgotp_page.vb        # Password recovery
├── marketing.vb           # Marketing and benefits information
├── profile.vb             # User profile management
└── *.Designer.vb          # Auto-generated UI design files

🚀 Getting Started
Prerequisites

.NET 6.0 or higher

SQL Server (or compatible SQL database)

Visual Studio 2022 or later

Installation

Clone the repository

Open GUI.vbproj in Visual Studio

Configure the SQL connection string in the database layer

Build and run the application

🔧 Database Schema (Conceptual)

The application uses a relational SQL database with the following core tables:

Users – User credentials and profile information

Equipment – Available farming machinery and pricing

Bookings – Equipment rental transactions

EducationalContent – Farming guides and educational resources

🎯 Key Functionality

CRUD Operations: Full Create, Read, Update, and Delete support

Form Validation: Robust validation to ensure data accuracy

Navigation Flow: Intuitive transitions between forms

Data Integrity: SQL-backed persistent storage

User Experience: Responsive and user-friendly Windows Forms UI

📸 Screenshots

(Screenshots to be added)

Login & Registration Interface

Equipment Rental Catalog

Educational Content Display

User Profile Management

📄 License

This project is intended for educational and portfolio purposes.
