🚜 Farm Equipment Rental Platform
A comprehensive Windows Forms application for managing farming equipment rentals, built with VB.NET and SQL database.

📋 Overview
This application provides a complete solution for farmers to rent equipment, access educational farming resources, and manage their profiles through an intuitive Windows Forms interface with full CRUD (Create, Read, Update, Delete) functionality.

✨ Features
🔐 User Management
Secure login and registration system

Password recovery functionality

User profile management

Form validation (email, phone, required fields)

🛠️ Equipment Rental
Browse available farming equipment

Real-time pricing display (R1400-R3000/hour)

Checkout system with item count and total calculation

Equipment categories: Tractors, Harvesters, Watering systems, etc.

📚 Educational Resources
Farming guides and tutorials

Crop lifecycle information

Modern farming techniques

💼 Marketing & Information
Benefits of equipment hiring

FAQ section addressing common questions

Try-before-you-buy options

Tax benefit explanations

🛠️ Technology Stack
Frontend: VB.NET, Windows Forms

Backend: SQL Database

Architecture: Multi-form application with CRUD operations

Validation: Custom validation functions

Navigation: Form-to-form with hide/show transitions

📁 Project Structure
text
GUI/
├── My Project/           # Application configuration
├── Form1.vb              # Login/Registration
├── home_page.vb          # Main dashboard
├── hirepage.vb           # Equipment rental
├── Education.vb          # Educational content
├── FAQ.vb               # FAQ and marketing
├── forgotp_page.vb      # Password recovery
├── marketing.vb         # Marketing information
├── profile.vb           # User profile
└── *.Designer.vb        # UI design files
🚀 Getting Started
Prerequisites
.NET 6.0 or higher

SQL Server (or compatible database)

Visual Studio 2022+

Installation
Clone the repository

Open GUI.vbproj in Visual Studio

Configure SQL connection string in your database layer

Build and run the application

🔧 Database Schema (Conceptual)
The application uses SQL for:

Users Table: User credentials and profiles

Equipment Table: Available machinery with pricing

Bookings Table: Rental transactions

Educational Content: Farming guides and articles

🎯 Key Functionality
CRUD Operations: Full Create, Read, Update, Delete capabilities

Form Validation: Comprehensive input validation

Navigation Flow: Intuitive form-to-form transitions

Data Integrity: SQL-backed data persistence

User Experience: Responsive Windows Forms interface

📸 Screenshots
(Screenshots to be added)

Login/Registration Interface

Equipment Rental Catalog

Educational Content Display

User Profile Management

📄 License
This project is for educational and portfolio purposes.
