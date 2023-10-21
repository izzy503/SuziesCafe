# Vendor and Order Tracker

Welcome to the Vendor and Order Tracker application, designed to help Suzie manage his bakery business relationships. This ASP.NET Core MVC application allows Suzie to track vendors and their associated orders for baked goods.

## Table of Contents

- [Features](#features)
- [Getting Started](#getting-started)
- [Usage](#usage)
- [Project Structure](#project-structure)
- [Contributing](#contributing)
- [Technologies Used](#technologies-used)
- [Running Tests/Setup Installations](#running-tests)
- [Known Bugs](#known-bugs)
- [License](#license)
- [GitHub Repository](#github-repository)

## Features

- Create and manage vendors with names and descriptions.
- Create and manage orders for each vendor with titles, descriptions, prices, and dates.
- View a list of vendors and their orders.
- Create new vendors and orders via user-friendly forms.
- Follows RESTful MVC conventions for routing and organization.
- Simple static storage for vendors and orders (for demonstration purposes).

## Getting Started

To run this application locally, follow these steps:

1. Clone the repository to your local machine.
2. Open the project in your preferred development environment (e.g., Visual Studio, Visual Studio Code).
3. Build and run the application.

dotnet run

## Usage

Visit the homepage to get started.
Explore vendors and their orders.
Create new vendors and orders as needed.

## Project Structure

The project structure follows standard ASP.NET Core MVC conventions:

- Controllers: Contains controller classes for handling HTTP requests.
- Models: Contains the Vendor and Order classes.
- Views: Contains Razor views for rendering HTML.
- Program.cs: Defines the application entry point.
- VendorOrderTracker.csproj: Project file.
- VendorOrderTracker.Tests: Unit tests for models and controllers.

## Contributing

Contributions to this project are welcome. Feel free to open issues or pull requests to suggest improvements or report bugs.

## Technologies Used

- ASP.NET Core MVC
- C#
- .NET SDK
- Razor Views

## Running Tests/Setup Installations

To run tests for this project, follow these step-by-step instructions:

**Step 1: Open a Terminal or Command Prompt**

- Launch a terminal or command prompt on your computer.

**Step 2: Navigate to Your Project Directory**

- Use the `cd` (change directory) command to navigate to the root directory of your project, where the `.csproj` file is located.

cd path/to/YourProject

**Step 3: Run the Tests**

To run the tests for your project, use the following command:

dotnet test

**Step 4: Review Test Results**

dotnet test will execute your tests and display the results in the terminal. You'll see information about which tests passed and which failed, along with any error messages or exceptions encountered during testing.


## Known Bugs

There are no known bugs in this version of the Vendor and Order Tracker application. If you encounter any issues, please report them to the project repository.

## License

This project is licensed under the MIT License.

## GitHub Repository

The source code for this project is available on GitHub. You can view the repository at [GitHub Repository](https://github.com/izzy503/SuziesCafe.git).
