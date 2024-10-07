# Inventory Management System

This is a simple inventory management system implemented in C# with .NET. The project uses MongoDB for data storage and provides a console-based interface for managing products. Users can add, view, edit, delete, and search products using the console menu.

## Table of Contents
1. [Features](#features)
2. [Project Structure](#project-structure)
3. [Prerequisites](#prerequisites)
4. [Configuration](#configuration)
5. [Getting Started](#getting-started)

## Features
- **CRUD Operations**: Add, view, edit, and delete products in the inventory.
- **Search Functionality**: Search for products by name.
- **MongoDB Integration**: Stores inventory data using MongoDB collections.
- **Console-Based Interface**: User-friendly console menu for managing inventory.

## Project Structure
InventoryManagementSystem/
├── MongoDbHelper.cs          # Handles MongoDB connection and operations
├── Inventory.cs              # Business logic for inventory management
├── Product.cs                # Product model definition
├── Program.cs                # Main console-based entry point
├── appsettings.json          # MongoDB connection configuration
└── InventoryManagementSystem.csproj  # Project file

## Prerequisites
- .NET 6.0 or higher
- MongoDB (Local installation or MongoDB Atlas account)
- Visual Studio or any C# IDE


## Configuration
### MongoDB Connection String
* Configure your MongoDB connection string in the `appsettings.json` file. Update `<username>`, `<password>`, and `<your-database>` with your MongoDB credentials and database name.

**Example** `appsettings.json`:
```bash
{
  "MongoDbSettings": {
    "ConnectionString": "mongodb+srv://<username>:<password>@cluster0.mongodb.net/<your-database>?retryWrites=true&w=majority"
  }
}
```

## Getting Started
1. **Clone the repository**:
   
    ```bash
    git clone https://github.com/yourusername/inventory-management-system.git
    cd inventory-management-system
    ```
2. **Restore the project dependencies**:
   
    ```bash
    dotnet restore
    ```
3. **Build the project**:

   ```bash
    dotnet build
    ```

4. **Run the project**:
   
    ```bash
    dotnet run
    ```
