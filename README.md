# Nextlane

ASP.NET CRUD Application and Console Exercises

## Description

This project features an ASP.NET web application that performs CRUD operations, complemented by a console application with a variety of exercises. It aims to showcase essential C# concepts and practices, such as error handling, class design, and API implementation.

## Running the ASP.NET Web Application

1. Launch the solution in Visual Studio.
2. In the Solution Explorer, find the web application project.
3. Right-click on the web application project.
4. Click the **Start** button to execute the application locally or press **F5**.
5. The web application will launch in your web browser.

### Testing the APIs

You can test the APIs using Swagger or Postman. 
In Swagger the browser will contain the correct URL, on Postman you need to insert the following URL for the type you want "http://localhost:5000/api/products" and "https://localhost:5001/api/orders/customer/(between 1 and 2)"

## Features and Code Examples

- **String Reversal Function**: A custom function in C# that reverses a string without using predefined methods like `Array.Reverse` or `String.Reverse`.

- **Static vs. Instance Methods**: An example demonstrating the difference between static methods and instance methods in C#.

- **Exception Handling**: A C# code snippet that catches a specific exception, such as `ArgumentNullException`, and handles it gracefully to allow the program to continue running.

- **Vehicle Class Design**: A `Vehicle` class with properties like `Brand`, `Model`, and `Year`. The derived class `Car` adds the `FuelType` property and includes a method to calculate fuel efficiency based on distance and consumption.

- **RESTful API Implementation**: A basic RESTful API in C# that performs CRUD operations on a `Product` entity with properties `Id`, `Name`, and `Price`.

- **Entity Framework Data Model**: A data model in C# using Entity Framework that represents a one-to-many relationship between `Customer` and `Order` entities.

- **Unit Testing with xUnit**: A set of unit tests using xUnit to validate the functionality of the RESTful API created.

## Note

You need to have the necessary dependencies installed before running the applications.
