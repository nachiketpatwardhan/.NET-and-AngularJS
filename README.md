# Car Dealership Project

## Overview

The Car Dealership project is a simple web application that demonstrates basic CRUD (Create, Read, Update, Delete) operations for managing car information. The project is divided into two parts:

1. **Backend (ASP.NET Core)**
   - Handles the server-side logic and provides API endpoints for car operations.

2. **Frontend (AngularJS)**
   - Implements the user interface to interact with the backend API.

## Project Structure

### Backend (.NET)

- **Controllers:** Contains API controllers for handling car operations.
- **Models:** Defines the data model for cars.
- **Properties:** Configuration files and other project properties.
- **appsettings.json:** Configuration settings for the application.
- **CarDealershipApi.csproj:** .NET project file.
- **Program.cs:** Entry point for the application.
- **Startup.cs:** Configuration of the application services and middleware.

### Frontend (AngularJS)

- **angular:** AngularJS application folder.
  - **views:** HTML templates for different sections of the application.
  - **app.controller.js:** AngularJS controller containing the logic for car operations.
- **index.html:** Main HTML file that includes AngularJS and sets up the application structure.
- **Other frontend-related files:** Stylesheets, images, or additional scripts.

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) for running the backend.
- A web browser or a simple server (e.g., [http-server](https://www.npmjs.com/package/http-server)) for the frontend.

### Running the Application

1. **Backend:**
   - Navigate to the backend project directory.
   - Run `dotnet run`.
   - The API will be accessible at `https://localhost:5001/api/car`.

2. **Frontend:**
   - Open `index.html` in a web browser or serve it using a simple server.
   - Access the frontend application in the browser.

## Usage

- The frontend provides a user interface with sections for viewing cars, buying a car, updating a car, and deleting a car.
- The backend API handles requests for car data and performs CRUD operations.

UI Example:

![Screenshot](Screenshot 2024-03-04 172401.png)

